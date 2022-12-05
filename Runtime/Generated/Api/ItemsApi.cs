using System;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using Object = System.Object;

namespace MetafabSdk
{
	public class ItemsApi
	{
		ApiClient apiClient;

		public ItemsApi(ApiClient apiClient) {
			this.apiClient = apiClient;
		}


		/// <summary>
		/// Batch mint collection items
		/// </summary>
		///
		/// <remarks>
		/// Creates (mints) the provided itemIds of the specified quantities to the provided wallet address or wallet address associated with the provided walletId.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> BatchMintCollectionItems(string collectionId, BatchMintCollectionItemsRequest batchMintCollectionItemsRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<TransactionModel>($"/v1/collections/{collectionId}/batchMints?sdk=unity", batchMintCollectionItemsRequest);

		}

		/// <summary>
		/// Batch transfer collection items
		/// </summary>
		///
		/// <remarks>
		/// Transfers one or multiple items of specified quantities to the provided wallet addresses or wallet addresses associated with the provided walletIds. You may also provide a combination of addresses and walletIds in one request.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> BatchTransferCollectionItems(string collectionId, BatchTransferCollectionItemsRequest batchTransferCollectionItemsRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<TransactionModel>($"/v1/collections/{collectionId}/batchTransfers?sdk=unity", batchTransferCollectionItemsRequest);

		}

		/// <summary>
		/// Burn collection item
		/// </summary>
		///
		/// <remarks>
		/// Removes (burns) the provided quantity of the collectionItemId from the authenticating game or players wallet. The quantity is permanently removed from the circulating supply of the item.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> BurnCollectionItem(string collectionId, float collectionItemId, BurnCollectionItemRequest burnCollectionItemRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<TransactionModel>($"/v1/collections/{collectionId}/items/{collectionItemId}/burns?sdk=unity", burnCollectionItemRequest);

		}

		/// <summary>
		/// Create collection
		/// </summary>
		///
		/// <remarks>
		/// Creates a new game item collection and deploys an extended functionality ERC1155 contract on behalf of the authenticating game's primary wallet. The deployed ERC1155 contract is preconfigured to fully support creating unique item types, item transfer timelocks, custom metadata per item, gasless transactions from player managed wallets, and much more.
		/// </remarks>
		/// <returns>CreateCollection200Response</returns>
		public async UniTask<CreateCollection200Response> CreateCollection(CreateCollectionRequest createCollectionRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<CreateCollection200Response>($"/v1/collections?sdk=unity", createCollectionRequest);

		}

		/// <summary>
		/// Create collection item
		/// </summary>
		///
		/// <remarks>
		/// Creates a new item type. Item type creation associates all of the relevant item data to a specific itemId. Such as item name, image, description, attributes, any arbitrary data such as 2D or 3D model resolver URLs, and more. It is recommended, but not required, that you create a new item type through this endpoint before minting any quantity of the related itemId.  Any itemId provided will have its existing item type overriden if it already exists.  Item type data is uploaded to, and resolved through IPFS for decentralized persistence.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> CreateCollectionItem(string collectionId, CreateCollectionItemRequest createCollectionItemRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<TransactionModel>($"/v1/collections/{collectionId}/items?sdk=unity", createCollectionItemRequest);

		}

		/// <summary>
		/// Get collection approval
		/// </summary>
		///
		/// <remarks>
		/// Returns a boolean (true/false) representing if the provided operatorAddress has approval to transfer and burn items from the current collection owned by the address or address associated with the provided walletId.
		/// </remarks>
		/// <returns>bool?</returns>
		public async UniTask<bool?> GetCollectionApproval(string collectionId, string operatorAddress,string address,string walletId,CancellationToken token = default)
		{
			
			return await apiClient.Get<bool?>($"/v1/collections/{collectionId}/approvals?sdk=unity&operatorAddress={ operatorAddress }&address={ address }&walletId={ walletId }");

		}

		/// <summary>
		/// Get collection item
		/// </summary>
		///
		/// <remarks>
		/// Returns a metadata object for the provided collectionItemId.
		/// </remarks>
		/// <returns>Object</returns>
		public async UniTask<Object> GetCollectionItem(string collectionId, float collectionItemId, CancellationToken token = default)
		{
			
			return await apiClient.Get<Object>($"/v1/collections/{collectionId}/items/{collectionItemId}?sdk=unity");

		}

		/// <summary>
		/// Get collection item balance
		/// </summary>
		///
		/// <remarks>
		/// Returns the current collection item balance of the provided collectionItemId for the provided wallet address or the wallet address associated with the provided walletId.
		/// </remarks>
		/// <returns>int</returns>
		public async UniTask<int> GetCollectionItemBalance(string collectionId, float collectionItemId, string address,string walletId,CancellationToken token = default)
		{
			
			return await apiClient.Get<int>($"/v1/collections/{collectionId}/items/{collectionItemId}/balances?sdk=unity&address={ address }&walletId={ walletId }");

		}

		/// <summary>
		/// Get collection item balances
		/// </summary>
		///
		/// <remarks>
		/// Returns the current collection item balances of all collection items for the provided wallet address or the wallet address associated with the provided walletId.
		/// </remarks>
		/// <returns>Dictionary&lt;string, float&gt;</returns>
		public async UniTask<Dictionary<string, float>> GetCollectionItemBalances(string collectionId, string address,string walletId,CancellationToken token = default)
		{
			
			return await apiClient.GetDictionary($"/v1/collections/{collectionId}/balances?sdk=unity&address={ address }&walletId={ walletId }");

		}

		/// <summary>
		/// Get collection item supplies
		/// </summary>
		///
		/// <remarks>
		/// Returns the currency circulating supply of all collection items.
		/// </remarks>
		/// <returns>Dictionary&lt;string, float&gt;</returns>
		public async UniTask<Dictionary<string, float>> GetCollectionItemSupplies(string collectionId, CancellationToken token = default)
		{
			
			return await apiClient.GetDictionary($"/v1/collections/{collectionId}/supplies?sdk=unity");

		}

		/// <summary>
		/// Get collection item supply
		/// </summary>
		///
		/// <remarks>
		/// Returns the current circulating supply of the provided collectionItemId.
		/// </remarks>
		/// <returns>int</returns>
		public async UniTask<int> GetCollectionItemSupply(string collectionId, float collectionItemId, string address,string walletId,CancellationToken token = default)
		{
			
			return await apiClient.Get<int>($"/v1/collections/{collectionId}/items/{collectionItemId}/supplies?sdk=unity&address={ address }&walletId={ walletId }");

		}

		/// <summary>
		/// Get collection item timelock
		/// </summary>
		///
		/// <remarks>
		/// Returns a timestamp (in seconds) for when the provided collectionItemId's transfer timelock expires. A value of 0 means the provided collectionItemId does not have a timelock set. Timelocks prevent items of a specific collectionItemId from being transferred until the set timelock timestamp has been surpassed.
		/// </remarks>
		/// <returns>int</returns>
		public async UniTask<int> GetCollectionItemTimelock(string collectionId, float collectionItemId, CancellationToken token = default)
		{
			
			return await apiClient.Get<int>($"/v1/collections/{collectionId}/items/{collectionItemId}/timelocks?sdk=unity");

		}

		/// <summary>
		/// Get collection items
		/// </summary>
		///
		/// <remarks>
		/// Returns all collection items as an array of metadata objects.  Please note that ONLY items that have had at least 1 quantity minted will be returned. If you've created an item that has not been minted yet, it will not be returned in the array response.
		/// </remarks>
		/// <returns>List&lt;Object&gt;</returns>
		public async UniTask<List<Object>> GetCollectionItems(string collectionId, CancellationToken token = default)
		{
			
			return await apiClient.Get<List<Object>>($"/v1/collections/{collectionId}/items?sdk=unity");

		}

		/// <summary>
		/// Get collection role
		/// </summary>
		///
		/// <remarks>
		/// Returns a boolean (true/false) representing if the provided role for this collection has been granted to the provided address or address associated with the provided walletId.
		/// </remarks>
		/// <returns>bool?</returns>
		public async UniTask<bool?> GetCollectionRole(string collectionId, string role,string address,string walletId,CancellationToken token = default)
		{
			
			return await apiClient.Get<bool?>($"/v1/collections/{collectionId}/roles?sdk=unity&role={ role }&address={ address }&walletId={ walletId }");

		}

		/// <summary>
		/// Get collections
		/// </summary>
		///
		/// <remarks>
		/// Returns an array of active item collections for the game associated with the provided `X-Game-Key`.
		/// </remarks>
		/// <returns>List&lt;GetCollections200ResponseInner&gt;</returns>
		public async UniTask<List<GetCollections200ResponseInner>> GetCollections(CancellationToken token = default)
		{
			
			return await apiClient.Get<List<GetCollections200ResponseInner>>($"/v1/collections?sdk=unity");

		}

		/// <summary>
		/// Grant collection role
		/// </summary>
		///
		/// <remarks>
		/// Grants the provided role for the collection to the provided address or address associated with the provided walletId. Granted roles give different types of authority on behalf of the collection for specific players, addresses, or contracts to perform different types of permissioned collection operations.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> GrantCollectionRole(string collectionId, GrantCollectionRoleRequest grantCollectionRoleRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<TransactionModel>($"/v1/collections/{collectionId}/roles?sdk=unity", grantCollectionRoleRequest);

		}

		/// <summary>
		/// Mint collection item
		/// </summary>
		///
		/// <remarks>
		/// Creates (mints) the specified quantity of the provided collectionItemId to the provided wallet address or wallet address associated with the provided walletId.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> MintCollectionItem(string collectionId, float collectionItemId, MintCollectionItemRequest mintCollectionItemRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<TransactionModel>($"/v1/collections/{collectionId}/items/{collectionItemId}/mints?sdk=unity", mintCollectionItemRequest);

		}

		/// <summary>
		/// Revoke collection role
		/// </summary>
		///
		/// <remarks>
		/// Revokes the provided role for the collection to the provided address or address associated with the provided walletId.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> RevokeCollectionRole(string collectionId, RevokeCollectionRoleRequest revokeCollectionRoleRequest, CancellationToken token = default)
		{
			
			return await apiClient.Delete<TransactionModel>($"/v1/collections/{collectionId}/roles?sdk=unity", revokeCollectionRoleRequest);

		}

		/// <summary>
		/// Set collection approval
		/// </summary>
		///
		/// <remarks>
		/// Sets approval for the provided address or wallet address associated with the provided walletId to operate on behalf of the authenticating game or player's owned items for this collection. Setting an approved value of `true` allows the provided address or address associated with the provided walletId to transfer and burn items from this collection on behalf of the authenticated game or player's wallet address.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> SetCollectionApproval(string collectionId, SetCollectionApprovalRequest setCollectionApprovalRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<TransactionModel>($"/v1/collections/{collectionId}/approvals?sdk=unity", setCollectionApprovalRequest);

		}

		/// <summary>
		/// Set collection item timelock
		/// </summary>
		///
		/// <remarks>
		/// Sets the item timelock for the provided collection itemId. The timelock is a unix timestamp (in seconds) that defines a period in time of when an item may be transferred by players. Until the timelock timestamp has passed, the itemId for the given timelock may not be transferred, sold, traded, etc. A timelock of 0 (default) means that there is no timelock set on the itemId and it can be freely transferred, traded, etc.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> SetCollectionItemTimelock(string collectionId, float collectionItemId, SetCollectionItemTimelockRequest setCollectionItemTimelockRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<TransactionModel>($"/v1/collections/{collectionId}/items/{collectionItemId}/timelocks?sdk=unity", setCollectionItemTimelockRequest);

		}

		/// <summary>
		/// Transfer collection item
		/// </summary>
		///
		/// <remarks>
		/// Transfers specified quantity of itemId to the provided wallet address or wallet address associated with the provided walletId.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> TransferCollectionItem(string collectionId, float collectionItemId, TransferCollectionItemRequest transferCollectionItemRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<TransactionModel>($"/v1/collections/{collectionId}/items/{collectionItemId}/transfers?sdk=unity", transferCollectionItemRequest);

		}
	}
}
