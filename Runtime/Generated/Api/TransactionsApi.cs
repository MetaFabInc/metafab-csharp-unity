using System;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using Object = System.Object;

namespace MetafabSdk
{
	public class TransactionsApi
	{
		ApiClient apiClient;

		public TransactionsApi(ApiClient apiClient) {
			this.apiClient = apiClient;
		}


		/// <summary>
		/// Get transaction
		/// </summary>
		///
		/// <remarks>
		/// Returns an executed transaction object for the provided transactionId. Transactions are created by MetaFab when interacting with contracts, currencies, items and other MetaFab resources.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> GetTransaction(string transactionId, CancellationToken token = default)
		{
			
			return await apiClient.Get<TransactionModel>($"/v1/transactions/{transactionId}?sdk=unity");

		}
	}
}
