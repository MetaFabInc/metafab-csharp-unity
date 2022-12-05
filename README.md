# Metafab SDK For Unity

## Installation (Package Manager via git url)

Add these lines to `Packages/manifest.json`:

```
"com.metafab.sdk": "https://github.com/MetaFabInc/metafab-csharp-unity.git",
"com.cysharp.unitask": "https://github.com/Cysharp/UniTask.git?path=src/UniTask/Assets/Plugins/UniTask#2.3.3"
```

## Getting Started

1. Retrieve your metafab credentials: https://docs.trymetafab.com/docs/first-steps-start-here

2. Set credentials in `Edit > Project Settings > Metafab`

3. Add a GameObject to your scene with this MonoBehaviour:

```csharp
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using MetafabSdk;
using UnityEngine;

public class MetafabHelloWorld : MonoBehaviour
{
	async UniTaskVoid Start()
	{
		Debug.Log("Authing game...");
		var response = await Metafab.GamesApi.AuthGame(Config.Email, Config.Password, default);
		Debug.Log($"{response}");
	}
}
```

## Support

The Unity SDK is a work in progress. For support, [open an issue](https://github.com/MetaFabInc/metafab-csharp-unity/issues) or [join us on discord](https://discord.gg/invite/metafab).

## Full Example

This example creates a player, collection, currency, items, and a shop with two offers:

* exchange MATIC for in-game currency
* exchange MATIC for in-game item

:warning: This script will require the game and player's wallets to be funded. :warning:

:money_with_wings:
Goerli testnet faucet (ETH): https://goerlifaucet.com/

:money_with_wings: Mumbai faucet (MATIC): https://faucet.polygon.technology/


```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MetafabSdk;
using Cysharp.Threading.Tasks;
using System;
using System.Linq;

public class FullMetafabExample : MonoBehaviour
{
	public Chain chain = Chain.MATICMUMBAI;

	public string playerUsername = "sample-player";
	public string playerPassword = "password";

	public string currencyName = "My Test Coin";
	public string currencySymbol = "$MYTEST";

	// toggle this to true once you have successfully created the exchanges
	public bool skipSetup = false;

	async UniTaskVoid Start()
	{
		Config.LogLevel = LogLevel.Debug;

		if (string.IsNullOrEmpty(Config.Email) || string.IsNullOrEmpty(Config.Password)) {
			Debug.LogError($"Metafab Email or Password are not set. Please set them in Edit > Project Settings > Metafab");
			return;
		}

		// authenticate game
		Log($"Games.AuthGame...");
		var response = await Metafab.GamesApi.AuthGame(Config.Email, Config.Password, default);
		Log($"AuthenticateGame {response}");
		Config.PublishedKey = response.publishedKey;
		Metafab.PublishedKey = Config.PublishedKey;
		Metafab.SecretKey = response.secretKey;
		Metafab.Password = Config.Password;

		// check balances
		Log($"Checking balances...");
		var balances = await Metafab.WalletsApi.GetWalletBalances(response.walletId);
		if (Mathf.Approximately(balances[chain.ToString()], 0)) {
			Log($"This game has no funds on the {chain.ToString()} chain. To fund the wallet, send money to:");
			Debug.Log($"{response.wallet.address}");
			return;
		}

		Log($"Game Wallet Balance {response.wallet.address}: {balances[chain.ToString()]}");
		balances = await Metafab.WalletsApi.GetWalletBalances(response.fundingWalletId);
		Log($"Game Funding Wallet Balance {response.fundingWallet.address}: {balances[chain.ToString()]}");

		// create resources
		if (!skipSetup) {
			await Setup(response);
		}

		// get player and authenticate
		Log($"Getting player...");
		var players = await Metafab.PlayersApi.GetPlayers();
		var player = players[players.Count - 1];
		Log($"Got player {player}.");

		var walletBalances = await Metafab.WalletsApi.GetWalletBalances(player.wallet.id);
		if (Mathf.Approximately(0, walletBalances[chain.ToString()])) {
			Log($"The player has no funds on the {chain.ToString()} chain. To fund the player's wallet, send money to:");
			Debug.Log($"{player.wallet.address}");
			return;
		}

		Log($"Authing player...");
		var auth = await Metafab.PlayersApi.AuthPlayer(player.username, playerPassword);
		Log($"Got auth {auth}");

		// get collection
		Log($"Getting collection...");
		var collections = await Metafab.ItemsApi.GetCollections();
		var collection = collections[collections.Count - 1];
		Log($"Got collection {collection}");

		// get currency
		Log($"Getting currency...");
		var currencies = await Metafab.CurrenciesApi.GetCurrencies();
		var currency = currencies[currencies.Count - 1];
		Log($"Got currency {currency}");

		// Display balances
		await DisplayBalances(collection, player);

		// Create exchange
		Log($"Getting shop...");
		var shops = await Metafab.ShopsApi.GetShops();
		var shop = shops.First(s => s.contract.chain == chain.ToString());
		Log($"Got shop: {shop}");

		// get shop offers
		Log($"Getting offers...");
		var offers = await Metafab.ShopsApi.GetShopOffers(shop.id);
		var currencyOffer = offers[offers.Count-2];
		var itemOffer = offers[offers.Count-1];

		Metafab.SecretKey = auth.accessToken;
		Metafab.Password = playerPassword;

		// buy currency w matic on exchange
		Log($"Using currency offer: {currencyOffer}");
		await Metafab.ShopsApi.UseShopOffer(shop.id, currencyOffer.id.ToString());
		Log($"Success!");

		// buy items w matic on exchange
		Log($"Using items offer: {itemOffer}");
		await Metafab.ShopsApi.UseShopOffer(shop.id, itemOffer.id.ToString());
		Log($"Success!");

		// Display balances
		await DisplayBalances(collection, player);

		Log($"Done!");
	}

	async UniTask Setup(AuthGame200Response game) {
		Log($"Creating player...");
		string playerWallet = null;
		try {
			var player = await Metafab.PlayersApi.CreatePlayer(new CreatePlayerRequest(
				playerUsername, playerPassword
			));
			Log($"Created player: {player}");
			playerWallet = player.wallet.address;
		} catch(UnityWebRequestException e) {
			if (e.Text == null || !e.Text.Contains("already exists")) {
				throw e;
			}

			var players = await Metafab.PlayersApi.GetPlayers();
			var player = players.First(p => p.username == playerUsername);
			playerWallet = player.wallet.address;
		}

		// create collection
		Log($"Creating collection...");
		var collection = await Metafab.ItemsApi.CreateCollection(new CreateCollectionRequest(
			chain.ToString()
		));
		Log($"Created collection: {collection}");

		// create currency
		Log($"Creating currency...");
		var currency = await Metafab.CurrenciesApi.CreateCurrency(new CreateCurrencyRequest(
			currencyName, currencySymbol, 0f, chain.ToString()
		));
		Log($"Created currency: {currency}");

		// create items
		Log($"Creating item...");
		var item = await Metafab.ItemsApi.CreateCollectionItem(collection.id, new CreateCollectionItemRequest(
			1, "Metafab Sample Item", "This is the first item created by the Metafab Sample Project", null, "https://upload.wikimedia.org/wikipedia/en/7/73/Smokeycover.jpg", null, null, null
		));
		Log($"Created item: {item}");

		// create exchange
		Log($"Creating shop...");
		var shop = await Metafab.ShopsApi.CreateShop(new CreateShopRequest(
			chain.ToString()
		));
		Log($"Created shop: {shop}");

		// grant shop currency minter role
		Log($"Granting currency minter role to shop...");
		var grantCurrency = await Metafab.CurrenciesApi.GrantCurrencyRole(currency.id, new GrantCurrencyRoleRequest(
			"minter", shop.contract.address, null
		));
		Log($"Granted currency minter role: {grantCurrency}");

		// grant shop collection minter role
		Log($"Granting collection minter role to shop...");
		var grantCollection = await Metafab.ItemsApi.GrantCollectionRole(collection.id, new GrantCollectionRoleRequest(
			"minter", shop.contract.address, null
		));
		Log($"Granted collection minter role: {grantCollection}");

		// create shop offer for currency
		Log($"Creating shop offer for currency...");
		var offerReq = new SetShopOfferRequest(
			// offer id
			1,
			// input collection address and id
			null, null,
			// input item ids and amounts
			null, null,
			// input currency address and id
			null, null,
			// input currency amount
			0.01f,
			// output collection address and id
			null, null,
			// output item ids and amounts
			null, null,
			// output currency address and id,
			currency.contract.address, currency.id,
			// output currency amount
			0.01f,
			// max uses
			0
		);
		var offerResp = await Metafab.ShopsApi.SetShopOffer(shop.id, offerReq);
		Log($"Created currency offer: {offerResp}");

		// create exchange offer for items
		Log($"Creating shop offer for items...");
		offerReq = new SetShopOfferRequest(
			// offer id
			2,
			// input collection address and id
			null, null,
			// input item ids and amounts
			null, null,
			// input currency address and id
			null, null,
			// input currency amount
			0.01f,
			// output collection address and id
			null, collection.id,
			// output item ids and amounts
			new List<int>() {1}, new List<int>() {1},
			// output currency address and id,
			null, null,
			// output currency amount
			0f,
			// max uses
			0
		);
		offerResp = await Metafab.ShopsApi.SetShopOffer(shop.id, offerReq);
		Log($"Created item offer: {offerResp}");

		// Mint items
		await Mint(playerWallet, collection.id, currency.id);
	}

	async UniTask<PublicPlayer> FindOrCreatePlayer() {
		Log($"Players.GetPlayers...");
		var playersJson = await Metafab.PlayersApi.GetPlayers();
		if (playersJson.Count > 0) {
			return playersJson[playersJson.Count - 1];
		}

		var username = System.Guid.NewGuid().ToString();
		var password = "password";
		Log($"Players.CreatePlayer...");
		var request = new CreatePlayerRequest(username, password);
		var response = await Metafab.PlayersApi.CreatePlayer(request);
		Log($"Created player: {response}");

		return new PublicPlayer(
			response.id, response.gameId, response.walletId, response.username, response.updatedAt, response.createdAt,
			new PublicPlayerWallet(response.wallet.id, response.wallet.address)
		);
	}

	async UniTask DisplayBalances(GetCollections200ResponseInner collection, PublicPlayer player) {
		Log($"Getting balances for player {player.wallet.address}...");
		var walletBalances = await Metafab.WalletsApi.GetWalletBalances(player.wallet.id);
		foreach(var entry in walletBalances) {
			Log($"chain={entry.Key} balance={entry.Value}");
		}

		var itemBalances = await Metafab.ItemsApi.GetCollectionItemBalances(collection.id, player.wallet.address, player.wallet.id);
		foreach(var entry in itemBalances) {
			Log($"item={entry.Key} balance={entry.Value}");
		}
	}

	async UniTask Mint(string walletAddress, string collectionId, string currencyId) {
		Log($"Minting currency...");
		var x = await Metafab.CurrenciesApi.MintCurrency(currencyId, new MintCurrencyRequest(1.0f, walletAddress, null));
		Log($"Minted currency: {x}");

		// Mint items
		Log($"Minting foo...");
		var req = new MintCollectionItemRequest(walletAddress, 1, null);
		var item = await Metafab.ItemsApi.MintCollectionItem(collectionId, 1, req);
		Log($"{item}");
		Log($"Minting bar...");
		item = await Metafab.ItemsApi.MintCollectionItem(collectionId, 2, req);
		Log($"{item}");
	}

	void Log(string s) {
		Debug.Log($"{Time.frameCount} | {s}");
	}
}
```

## Logging

Log levels in editor are controlled by settings in `Edit > Project Settings > Metafab`.

In builds all logging is disabled unless `METAFAB_LOGGING` is defined in Unity's `Scripting Define Symbols`