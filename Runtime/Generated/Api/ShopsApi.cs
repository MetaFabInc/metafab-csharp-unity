using System;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using Object = System.Object;

namespace MetafabSdk
{
	public class ShopsApi
	{
		ApiClient apiClient;

		public ShopsApi(ApiClient apiClient) {
			this.apiClient = apiClient;
		}


		/// <summary>
		/// Create shop
		/// </summary>
		///
		/// <remarks>
		/// Creates a new game shop and deploys a shop contract on behalf of the authenticating game's primary wallet. The deployed shop contract allows you to create fixed price rates for players to buy specific items from any item collection or ERC1155 contract. Additionally, a shop allows you to create shop offers for some set of item(s) to another set of item(s) or any mix of currency. Shops completely support gasless player transactions.
		/// </remarks>
		/// <returns>CreateShop200Response</returns>
		public async UniTask<CreateShop200Response> CreateShop(CreateShopRequest createShopRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<CreateShop200Response>($"/v1/shops?sdk=unity", createShopRequest);

		}

		/// <summary>
		/// Get shop offer
		/// </summary>
		///
		/// <remarks>
		/// Returns a shop offer object for the provided shopOfferId.
		/// </remarks>
		/// <returns>ShopOffer</returns>
		public async UniTask<ShopOffer> GetShopOffer(string shopId, string shopOfferId, CancellationToken token = default)
		{
			
			return await apiClient.Get<ShopOffer>($"/v1/shops/{shopId}/items/{shopOfferId}?sdk=unity");

		}

		/// <summary>
		/// Get shop offers
		/// </summary>
		///
		/// <remarks>
		/// Returns all shop offers as an array of shop offer objects.
		/// </remarks>
		/// <returns>List&lt;ShopOffer&gt;</returns>
		public async UniTask<List<ShopOffer>> GetShopOffers(string shopId, CancellationToken token = default)
		{
			
			return await apiClient.Get<List<ShopOffer>>($"/v1/shops/{shopId}/offers?sdk=unity");

		}

		/// <summary>
		/// Get shops
		/// </summary>
		///
		/// <remarks>
		/// Returns an array of active shops for the game associated with the provided `X-Game-Key`.
		/// </remarks>
		/// <returns>List&lt;GetShops200ResponseInner&gt;</returns>
		public async UniTask<List<GetShops200ResponseInner>> GetShops(CancellationToken token = default)
		{
			
			return await apiClient.Get<List<GetShops200ResponseInner>>($"/v1/shops?sdk=unity");

		}

		/// <summary>
		/// Remove shop offer
		/// </summary>
		///
		/// <remarks>
		/// Removes the provided offer by offerId from the provided shop. Removed offers can no longer be used.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> RemoveShopOffer(string shopId, string shopOfferId, CancellationToken token = default)
		{
			
			return await apiClient.Delete<TransactionModel>($"/v1/shops/{shopId}/offers/{shopOfferId}?sdk=unity");

		}

		/// <summary>
		/// Set shop offer
		/// </summary>
		///
		/// <remarks>
		/// Sets a new shop offer or updates an existing one for the provided id. Shop offers allow currency to item, item to currency or item to item exchanges.  All request fields besides `id` are optional. Any optional fields omitted will not be used for the offer. This allows you to create many different combinations of offers. For example, you can create an offer that may require 3 unique item ids of specified quantities from a given item collection and gives the user 1 new unique item id in exchange.  Another example, you may want to make a shop offer from one ERC20 token to another. This is also possible - simple set the input and output currency fields and leave the others blank.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> SetShopOffer(string shopId, SetShopOfferRequest setShopOfferRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<TransactionModel>($"/v1/shops/{shopId}/offers?sdk=unity", setShopOfferRequest);

		}

		/// <summary>
		/// Use shop offer
		/// </summary>
		///
		/// <remarks>
		/// Uses a shop offer. The required (input) item(s) and/or currency are removed from the wallet or player wallet using the offer. The given (output) item(s) and/or currency are given to the wallet or player wallet using the offer.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> UseShopOffer(string shopId, string shopOfferId, CancellationToken token = default)
		{
			
			return await apiClient.Post<TransactionModel>($"/v1/shops/{shopId}/offers/{shopOfferId}/uses?sdk=unity");

		}

		/// <summary>
		/// Withdraw from shop
		/// </summary>
		///
		/// <remarks>
		/// Withdraws native token, currency or items from a shop. Whenever a shop offer has input requirements, the native tokens, currencies or items for the requirements of that offer are deposited into the shop contract when the offer is used. These can be withdrawn to any other address.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> WithdrawFromShop(string shopId, WithdrawFromShopRequest withdrawFromShopRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<TransactionModel>($"/v1/shops/{shopId}/withdrawals?sdk=unity", withdrawFromShopRequest);

		}
	}
}
