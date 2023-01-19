using System;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using Object = System.Object;

namespace MetafabSdk
{
	public class ContractsApi
	{
		ApiClient apiClient;

		public ContractsApi(ApiClient apiClient) {
			this.apiClient = apiClient;
		}


		/// <summary>
		/// Create custom contract
		/// </summary>
		///
		/// <remarks>
		/// Create a MetaFab custom contract entry from an existing contract address and contract abi. This allows the game and players belonging to the authenticated game to interact with the contract's read and write functions through MetaFab's read and write contract endpoints.
		/// </remarks>
		/// <returns>ContractModel</returns>
		public async UniTask<ContractModel> CreateContract(CreateContractRequest createContractRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<ContractModel>($"/v1/contracts?sdk=unity", createContractRequest);

		}

		/// <summary>
		/// Get contracts
		/// </summary>
		///
		/// <remarks>
		/// Returns an array of active contracts deployed by the game associated with the provided `X-Game-Key`.
		/// </remarks>
		/// <returns>List<ContractModel></returns>
		public async UniTask<List<ContractModel>> GetContracts(CancellationToken token = default)
		{
			
			return await apiClient.Get<List<ContractModel>>($"/v1/contracts?sdk=unity");

		}

		/// <summary>
		/// Read contract data
		/// </summary>
		///
		/// <remarks>
		/// Oftentimes you'll want to query and retrieve some data from a contract. This is incredibly easy to do for any contract deployed through MetaFab.  Using this endpoint, you can get the data returned by any readable function listed in a contracts ABI. This could be things like querying the totalSupply of a currency contract, the number of owners of an items contract, and more.
		/// </remarks>
		/// <returns>Object</returns>
		public async UniTask<Object> ReadContract(string contractId, string func,string args,CancellationToken token = default)
		{
			
			return await apiClient.Get<Object>($"/v1/contracts/{contractId}/reads?sdk=unity&func={ func }&args={ args }");

		}

		/// <summary>
		/// Transfer contract ownership
		/// </summary>
		///
		/// <remarks>
		/// Transfer ownership and control of a MetaFab deployed smart contract to another wallet you control. Transferring control does not disrupt your usage of MetaFab APIs and can be done so without causing any service outages for your game. The new owner wallet will have full control over any relevant item collections and marketplace related pages this contract may be associated with, such as for MetaFab item or NFT contracts.  Your game's managed wallet will retain a `MANAGER_ROLE` on your contracts, allowing you to still use MetaFab APIs without issue while you retain full contract ownership and the contract's administrator role. If ever you want eject from using the MetaFab APIs but still retain your deployed smart contracts, you can revoke the `MANAGER_ROLE` from your game's managed wallet address for your contract. We do not lock you into our systems.  Please be certain that the wallet address you transfer ownership to is one you control. Once ownership and admin permissions are transferred, your game's managed wallet no longer has permission to reassign ownership or administrative priveleges for your contract.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> TransferContractOwnership(string contractId, TransferContractOwnershipRequest transferContractOwnershipRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<TransactionModel>($"/v1/contracts/{contractId}/owners?sdk=unity", transferContractOwnershipRequest);

		}

		/// <summary>
		/// Upgrade contract trusted forwarder
		/// </summary>
		///
		/// <remarks>
		/// In rare circumstances, you may need to upgrade the underlying trusted forwarder contract address attached to your game's contracts. Using this endpoint, you can provide a new trusted forwarder contract address to assign to any of your contracts that implement the `upgradeTrustedForwarder` function.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> UpgradeContractTrustedForwarder(string contractId, UpgradeContractTrustedForwarderRequest upgradeContractTrustedForwarderRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<TransactionModel>($"/v1/contracts/{contractId}/forwarders?sdk=unity", upgradeContractTrustedForwarderRequest);

		}

		/// <summary>
		/// Write contract data
		/// </summary>
		///
		/// <remarks>
		/// MetaFab's convenience endpoints for contract interactions may not be flexible enough depending on your use case. For these situations, you can interact with contracts and create transactions directly.  Using this endpoint, you can execute a transaction for any writeable contract method as defined in the contract's ABI for the MetaFab contractId provided. Both Games and Player resources have authority to use this endpoint to execute transactions against any valid MetaFab contractId.  Additionally, MetaFab will automatically attempt to perform a gasless transaction for players interacting with a contract through this endpoint. Gasless transactions by players through this endpoint will only work if the target contract was deployed through MetaFab or supports MetaFab's ERC2771 trusted forwarder contract.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> WriteContract(string contractId, WriteContractRequest writeContractRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<TransactionModel>($"/v1/contracts/{contractId}/writes?sdk=unity", writeContractRequest);

		}
	}
}
