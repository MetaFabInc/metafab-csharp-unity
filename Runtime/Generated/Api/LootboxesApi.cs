using System;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using Object = System.Object;

namespace MetafabSdk
{
	public class LootboxesApi
	{
		ApiClient apiClient;

		public LootboxesApi(ApiClient apiClient) {
			this.apiClient = apiClient;
		}


		/// <summary>
		/// Create lootbox manager
		/// </summary>
		///
		/// <remarks>
		/// Creates a new game lootbox manager and deploys a lootbox manager contract on behalf of the authenticating game's primary wallet. The deployed lootbox manager contract allows you to create lootbox behavior for existing items. For example, you can define item id(s) from one of your item collections as the requirement(s) to open a \"lootbox\". The required item(s) would be burned from the interacting player's wallet and the player would receive item(s) from a weighted randomized set of possible items the lootbox can contain.
		/// </remarks>
		/// <returns>CreateLootboxManager200Response</returns>
		public async UniTask<CreateLootboxManager200Response> CreateLootboxManager(CreateLootboxManagerRequest createLootboxManagerRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<CreateLootboxManager200Response>($"/v1/lootboxManagers?sdk=unity", createLootboxManagerRequest);

		}

		/// <summary>
		/// Get lootbox manager lootbox
		/// </summary>
		///
		/// <remarks>
		/// Returns a lootbox manager lootbox object for the provided lootboxManagerLootboxId.
		/// </remarks>
		/// <returns>LootboxManagerLootbox</returns>
		public async UniTask<LootboxManagerLootbox> GetLootboxManagerLootbox(string lootboxManagerId, string lootboxManagerLootboxId, CancellationToken token = default)
		{
			
			return await apiClient.Get<LootboxManagerLootbox>($"/v1/lootboxManagers/{lootboxManagerId}/lootboxes/{lootboxManagerLootboxId}?sdk=unity");

		}

		/// <summary>
		/// Get lootbox manager lootboxes
		/// </summary>
		///
		/// <remarks>
		/// Returns all lootbox manager lootboxes as an array of lootbox objects.
		/// </remarks>
		/// <returns>List&lt;LootboxManagerLootbox&gt;</returns>
		public async UniTask<List<LootboxManagerLootbox>> GetLootboxManagerLootboxes(string lootboxManagerId, CancellationToken token = default)
		{
			
			return await apiClient.Get<List<LootboxManagerLootbox>>($"/v1/lootboxManagers/{lootboxManagerId}/lootboxes?sdk=unity");

		}

		/// <summary>
		/// Get lootbox managers
		/// </summary>
		///
		/// <remarks>
		/// Returns an array of active lootbox managers for the game associated with the provided `X-Game-Key`.
		/// </remarks>
		/// <returns>List&lt;GetLootboxManagers200ResponseInner&gt;</returns>
		public async UniTask<List<GetLootboxManagers200ResponseInner>> GetLootboxManagers(CancellationToken token = default)
		{
			
			return await apiClient.Get<List<GetLootboxManagers200ResponseInner>>($"/v1/lootboxManagers?sdk=unity");

		}

		/// <summary>
		/// Open lootbox manager lootbox
		/// </summary>
		///
		/// <remarks>
		/// Opens a lootbox manager lootbox. The required input item(s) are burned from the wallet or player wallet opening the lootbox. The given output item(s) are given to the wallet or player wallet opening the lootbox.
		/// </remarks>
		/// <returns>List&lt;TransactionModel&gt;</returns>
		public async UniTask<List<TransactionModel>> OpenLootboxManagerLootbox(string lootboxManagerId, string lootboxManagerLootboxId, CancellationToken token = default)
		{
			
			return await apiClient.Post<List<TransactionModel>>($"/v1/lootboxManagers/{lootboxManagerId}/lootboxes/{lootboxManagerLootboxId}/opens?sdk=unity");

		}

		/// <summary>
		/// Remove lootbox manager lootbox
		/// </summary>
		///
		/// <remarks>
		/// Removes the provided lootbox by lootboxId from the provided lootbox manager. Removed lootboxes can no longer be used.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> RemoveLootboxManagerLootbox(string lootboxManagerId, string lootboxManagerLootboxId, CancellationToken token = default)
		{
			
			return await apiClient.Delete<TransactionModel>($"/v1/lootboxManagers/{lootboxManagerId}/lootboxes/{lootboxManagerLootboxId}?sdk=unity");

		}

		/// <summary>
		/// Set lootbox manager lootbox
		/// </summary>
		///
		/// <remarks>
		/// Sets a new lootbox manager lootbox or updates an existing one for the provided id. Lootboxes allow item(s) to be burned to receive a random set of possible item(s) based on probability weight.  Lootboxes can require any number of unique types of items and quantities to open a created lootbox type within the system. A common pattern with lootboxes is to create a lootbox item type within an item collection, and require it as the input item type.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> SetLootboxManagerLootbox(string lootboxManagerId, SetLootboxManagerLootboxRequest setLootboxManagerLootboxRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<TransactionModel>($"/v1/lootboxManagers/{lootboxManagerId}/lootboxes?sdk=unity", setLootboxManagerLootboxRequest);

		}
	}
}
