using System;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using Object = System.Object;

namespace MetafabSdk
{
	public class PlayersApi
	{
		ApiClient apiClient;

		public PlayersApi(ApiClient apiClient) {
			this.apiClient = apiClient;
		}


		/// <summary>
		/// Authenticate player
		/// </summary>
		///
		/// <remarks>
		/// Returns an existing player object containing access token, wallet, and other details for a game when provided a valid username and password login using Basic Auth.
		/// </remarks>
		/// <returns>AuthPlayer200Response</returns>
		public async UniTask<AuthPlayer200Response> AuthPlayer(string email, string password, CancellationToken token = default)
		{
			apiClient.BasicAuth = $"{email}:{password}";
			return await apiClient.Get<AuthPlayer200Response>($"/v1/players/auth?sdk=unity");

		}

		/// <summary>
		/// Create player
		/// </summary>
		///
		/// <remarks>
		/// Create a new player for a game. Players are automatically associated with an internally managed wallet.  Player access tokens can be used to directly interact with any MetaFab managed contracts, currencies, items collections, marketplaces and more. Player interactions are also gasless by default, completely removing all crypto friction for players to engage with your MetaFab supported games.
		/// </remarks>
		/// <returns>AuthPlayer200Response</returns>
		public async UniTask<AuthPlayer200Response> CreatePlayer(CreatePlayerRequest createPlayerRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<AuthPlayer200Response>($"/v1/players?sdk=unity", createPlayerRequest);

		}

		/// <summary>
		/// Get player
		/// </summary>
		///
		/// <remarks>
		/// Returns a player object for the provided player id.
		/// </remarks>
		/// <returns>PublicPlayer</returns>
		public async UniTask<PublicPlayer> GetPlayer(string playerId, CancellationToken token = default)
		{
			
			return await apiClient.Get<PublicPlayer>($"/v1/players/{playerId}?sdk=unity");

		}

		/// <summary>
		/// Get player data
		/// </summary>
		///
		/// <remarks>
		/// Returns the latest public and protected data as an object for the provided playerId.
		/// </remarks>
		/// <returns>GetPlayerData200Response</returns>
		public async UniTask<GetPlayerData200Response> GetPlayerData(string playerId, CancellationToken token = default)
		{
			
			return await apiClient.Get<GetPlayerData200Response>($"/v1/players/{playerId}/data?sdk=unity");

		}

		/// <summary>
		/// Get players
		/// </summary>
		///
		/// <remarks>
		/// Returns all players for the authenticated game as an array of player objects.
		/// </remarks>
		/// <returns>List<PublicPlayer></returns>
		public async UniTask<List<PublicPlayer>> GetPlayers(CancellationToken token = default)
		{
			
			return await apiClient.Get<List<PublicPlayer>>($"/v1/players?sdk=unity");

		}

		/// <summary>
		/// Remove player connected wallet
		/// </summary>
		///
		/// <remarks>
		/// Removes an external wallet from a player account. The player's wallet is reverted to their managed wallet.
		/// </remarks>
		/// <returns>HttpResponse</returns>
		public async UniTask<HttpResponse> RemovePlayerConnectedWallet(string playerId, string playerWalletId, RemovePlayerConnectedWalletRequest removePlayerConnectedWalletRequest, CancellationToken token = default)
		{
			
			return await apiClient.Delete<HttpResponse>($"/v1/players/{playerId}/wallets/{playerWalletId}?sdk=unity", removePlayerConnectedWalletRequest);

		}

		/// <summary>
		/// Set player connected wallet
		/// </summary>
		///
		/// <remarks>
		/// Sets an external wallet as the wallet for a player account. The set wallet can transact gaslessly with all MetaFab related systems through the same MetaFab API calls as managed wallets without requiring transaction signing or private keys.  This is done through an internal system MetaFab has created that allows an external connected wallet to delegate transaction signing for a specific game's set of contracts to a player's password protected managed wallet. This allow the managed wallet to sign and submit transactions to a specific game's related contracts as if they were signed and submitted by the connected external wallet. This also means that all earned tokens, purchased items and any interactions happen and are recorded on chain as the external connected wallet. No additional logic needs to be writted by developers to support both managed and external wallets, everything just works.  Finally, this endpoint is meant for advanced users. The majority of developers who want to implement external wallet support for their game can do so without any extra work through our whitelabeled wallet connection feature that implements this endpoint underneath the hood without any required work.
		/// </remarks>
		/// <returns>SetPlayerConnectedWallet200Response</returns>
		public async UniTask<SetPlayerConnectedWallet200Response> SetPlayerConnectedWallet(string playerId, SetPlayerConnectedWalletRequest setPlayerConnectedWalletRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<SetPlayerConnectedWallet200Response>($"/v1/players/{playerId}/wallets?sdk=unity", setPlayerConnectedWalletRequest);

		}

		/// <summary>
		/// Set player data
		/// </summary>
		///
		/// <remarks>
		/// Creates or updates public and/or protected data for the provided playerId. Data updates are performed using deep merging. This means that when you update any top level or nested properties specific to player public or protected data, you only need to include the properties you are making changes to. Any existing properties not included in request body arguments will be retained on the player data object.  Please note, When writing an array type for a player, arrays do not follow the deep merge approach. If you add or remove an item from an array, the entire array must be passed as an argument when updating the related property for player public or protected data.
		/// </remarks>
		/// <returns>GetPlayerData200Response</returns>
		public async UniTask<GetPlayerData200Response> SetPlayerData(string playerId, SetPlayerDataRequest setPlayerDataRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<GetPlayerData200Response>($"/v1/players/{playerId}/data?sdk=unity", setPlayerDataRequest);

		}

		/// <summary>
		/// Update player
		/// </summary>
		///
		/// <remarks>
		/// Update various fields specific to a player. Such as changing its password and resetting its access token.
		/// </remarks>
		/// <returns>PlayerModel</returns>
		public async UniTask<PlayerModel> UpdatePlayer(string playerId, UpdatePlayerRequest updatePlayerRequest, CancellationToken token = default)
		{
			
			return await apiClient.Patch<PlayerModel>($"/v1/players/{playerId}?sdk=unity", updatePlayerRequest);

		}
	}
}
