using System;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using Object = System.Object;

namespace MetafabSdk
{
	public class WalletsApi
	{
		ApiClient apiClient;

		public WalletsApi(ApiClient apiClient) {
			this.apiClient = apiClient;
		}


		/// <summary>
		/// Get wallet
		/// </summary>
		///
		/// <remarks>
		/// Returns a wallet object for the provided walletId.
		/// </remarks>
		/// <returns>WalletModel</returns>
		public async UniTask<WalletModel> GetWallet(string walletId, CancellationToken token = default)
		{
			
			return await apiClient.Get<WalletModel>($"/v1/wallets/{walletId}?sdk=unity");

		}

		/// <summary>
		/// Get wallet balances
		/// </summary>
		///
		/// <remarks>
		/// Returns the current native token balance for all chains supported by MetaFab for the provided walletId. This includes balances like Eth, Matic and other native tokens from chains MetaFab supports.
		/// </remarks>
		/// <returns>Dictionary<string, float></returns>
		public async UniTask<Dictionary<string, float>> GetWalletBalances(string walletId, CancellationToken token = default)
		{
			
			return await apiClient.GetDictionary($"/v1/wallets/{walletId}/balances?sdk=unity");

		}

		/// <summary>
		/// Get wallet transactions
		/// </summary>
		///
		/// <remarks>
		/// Returns an array of MetaFab initiated transactions performed by the provided walletId. Transactions returned are ordered chronologically from newest to oldest.
		/// </remarks>
		/// <returns>List<TransactionModel></returns>
		public async UniTask<List<TransactionModel>> GetWalletTransactions(string walletId, CancellationToken token = default)
		{
			
			return await apiClient.Get<List<TransactionModel>>($"/v1/wallets/{walletId}/transactions?sdk=unity");

		}
	}
}
