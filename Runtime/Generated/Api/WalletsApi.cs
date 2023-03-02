using System;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using Object = System.Object;

namespace MetafabSdk
{
	public partial class WalletsApi
	{
		ApiClient apiClient;

		public WalletsApi(ApiClient apiClient) {
			this.apiClient = apiClient;
		}


		/// <summary>
		/// Create wallet signature
		/// </summary>
		///
		/// <remarks>
		/// Creates a wallet signature from a plaintext message using the wallet for the provided walletId and walletDecryptKey. Wallet signatures cannot be generated for EOA wallets.
		/// </remarks>
		/// <returns>string</returns>
		public async UniTask<string> CreateWalletSignature(string walletId, CreateWalletSignatureRequest createWalletSignatureRequest, CancellationToken token = default, Dictionary<string, string> headers = null)
		{
			
			return await apiClient.Post<string>($"/v1/wallets/{walletId}/signatures?sdk=unity", createWalletSignatureRequest, headers: headers);

		}

		/// <summary>
		/// Get wallet
		/// </summary>
		///
		/// <remarks>
		/// Returns a wallet object for the provided walletId.
		/// </remarks>
		/// <returns>WalletModel</returns>
		public async UniTask<WalletModel> GetWallet(string walletId, CancellationToken token = default, Dictionary<string, string> headers = null)
		{
			
			return await apiClient.Get<WalletModel>($"/v1/wallets/{walletId}?sdk=unity", headers: headers);

		}

		/// <summary>
		/// Get wallet balances
		/// </summary>
		///
		/// <remarks>
		/// Returns the current native token balance for all chains supported by MetaFab for the provided walletId. This includes balances like Eth, Matic and other native tokens from chains MetaFab supports.
		/// </remarks>
		/// <returns>Dictionary<string, float></returns>
		public async UniTask<Dictionary<string, float>> GetWalletBalances(string walletId, CancellationToken token = default, Dictionary<string, string> headers = null)
		{
			
			return await apiClient.GetDictionary($"/v1/wallets/{walletId}/balances?sdk=unity", headers: headers);

		}

		/// <summary>
		/// Get wallet transactions
		/// </summary>
		///
		/// <remarks>
		/// Returns an array of MetaFab initiated transactions performed by the provided walletId. Transactions returned are ordered chronologically from newest to oldest.
		/// </remarks>
		/// <returns>List<TransactionModel></returns>
		public async UniTask<List<TransactionModel>> GetWalletTransactions(string walletId, CancellationToken token = default, Dictionary<string, string> headers = null)
		{
			
			return await apiClient.Get<List<TransactionModel>>($"/v1/wallets/{walletId}/transactions?sdk=unity", headers: headers);

		}
	}
}
