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
		/// <returns>List&lt;ContractModel&gt;</returns>
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
