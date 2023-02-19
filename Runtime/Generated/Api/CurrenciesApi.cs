using System;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using Object = System.Object;

namespace MetafabSdk
{
	public partial class CurrenciesApi
	{
		ApiClient apiClient;

		public CurrenciesApi(ApiClient apiClient) {
			this.apiClient = apiClient;
		}


		/// <summary>
		/// Batch transfer currency
		/// </summary>
		///
		/// <remarks>
		/// Transfers multiple amounts of currency to multiple provided wallet addresses or wallet addresses associated with the provided walletIds. You may also provide a combination of addresses and walletIds in one request, the proper receipients will be automatically determined, with `addresses` getting `amounts` order priority first.  Optional references may be included for the transfer. References are useful for identifying transfers intended to pay for items, trades, services and more.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> BatchTransferCurrency(string currencyId, BatchTransferCurrencyRequest batchTransferCurrencyRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<TransactionModel>($"/v1/currencies/{currencyId}/batchTransfers?sdk=unity", batchTransferCurrencyRequest);

		}

		/// <summary>
		/// Burn currency
		/// </summary>
		///
		/// <remarks>
		/// Removes (burns) the provided amount of currency from the authenticating game or players wallet. The currency amount is permanently removed from the circulating supply of the currency.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> BurnCurrency(string currencyId, BurnCurrencyRequest burnCurrencyRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<TransactionModel>($"/v1/currencies/{currencyId}/burns?sdk=unity", burnCurrencyRequest);

		}

		/// <summary>
		/// Create currency
		/// </summary>
		///
		/// <remarks>
		/// Creates a new game currency and deploys an ERC20 token contract on behalf of the authenticating game's primary wallet. The deployed ERC20 contract is preconfigured to fully support bridging across blockchains, batched transfers and gasless transactions on any supported blockchain as well as full support for gasless transactions from player managed wallets.
		/// </remarks>
		/// <returns>CreateCurrency200Response</returns>
		public async UniTask<CreateCurrency200Response> CreateCurrency(CreateCurrencyRequest createCurrencyRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<CreateCurrency200Response>($"/v1/currencies?sdk=unity", createCurrencyRequest);

		}

		/// <summary>
		/// Get currencies
		/// </summary>
		///
		/// <remarks>
		/// Returns an array of active currencies for the game associated with the provided `X-Game-Key`.
		/// </remarks>
		/// <returns>List<GetCurrencies200ResponseInner></returns>
		public async UniTask<List<GetCurrencies200ResponseInner>> GetCurrencies(CancellationToken token = default)
		{
			
			return await apiClient.Get<List<GetCurrencies200ResponseInner>>($"/v1/currencies?sdk=unity");

		}

		/// <summary>
		/// Get currency balance
		/// </summary>
		///
		/// <remarks>
		/// Returns the current currency balance of the provided wallet address or or the wallet address associated with the provided walletId.
		/// </remarks>
		/// <returns>float</returns>
		public async UniTask<float> GetCurrencyBalance(string currencyId, string address,string walletId,CancellationToken token = default)
		{
			
			return await apiClient.GetFloat($"/v1/currencies/{currencyId}/balances?sdk=unity&address={ address }&walletId={ walletId }");

		}

		/// <summary>
		/// Get currency fees
		/// </summary>
		///
		/// <remarks>
		/// Returns the current fee recipient address and fees of the currency for the provided currencyId. Fees are only applicable for gasless transactions performed by default by players.
		/// </remarks>
		/// <returns>GetCurrencyFees200Response</returns>
		public async UniTask<GetCurrencyFees200Response> GetCurrencyFees(string currencyId, CancellationToken token = default)
		{
			
			return await apiClient.Get<GetCurrencyFees200Response>($"/v1/currencies/{currencyId}/fees?sdk=unity");

		}

		/// <summary>
		/// Get currency role
		/// </summary>
		///
		/// <remarks>
		/// Returns a boolean (true/false) representing if the provided role for this currency has been granted to the provided address or address associated with the provided walletId.
		/// </remarks>
		/// <returns>bool?</returns>
		public async UniTask<bool?> GetCurrencyRole(string currencyId, string role,string address,string walletId,CancellationToken token = default)
		{
			
			return await apiClient.Get<bool?>($"/v1/currencies/{currencyId}/roles?sdk=unity&role={ role }&address={ address }&walletId={ walletId }");

		}

		/// <summary>
		/// Grant currency role
		/// </summary>
		///
		/// <remarks>
		/// Grants the provided role for the currency to the provided address or address associated with the provided walletId. Granted roles give different types of authority on behalf of the currency for specific players, addresses, or contracts to perform different types of permissioned currency operations.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> GrantCurrencyRole(string currencyId, GrantCurrencyRoleRequest grantCurrencyRoleRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<TransactionModel>($"/v1/currencies/{currencyId}/roles?sdk=unity", grantCurrencyRoleRequest);

		}

		/// <summary>
		/// Mint currency
		/// </summary>
		///
		/// <remarks>
		/// Creates (mints) the provided amount of currency to the provided wallet address or wallet address associated with the provided walletId.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> MintCurrency(string currencyId, MintCurrencyRequest mintCurrencyRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<TransactionModel>($"/v1/currencies/{currencyId}/mints?sdk=unity", mintCurrencyRequest);

		}

		/// <summary>
		/// Revoke currency role
		/// </summary>
		///
		/// <remarks>
		/// Revokes the provided role for the currency to the provided address or address associated with the provided walletId.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> RevokeCurrencyRole(string currencyId, RevokeCollectionRoleRequest revokeCollectionRoleRequest, CancellationToken token = default)
		{
			
			return await apiClient.Delete<TransactionModel>($"/v1/currencies/{currencyId}/roles?sdk=unity", revokeCollectionRoleRequest);

		}

		/// <summary>
		/// Set currency fees
		/// </summary>
		///
		/// <remarks>
		/// Sets the recipient address, basis points, fixed amount and cap amount for a currency's fees.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> SetCurrencyFees(string currencyId, SetCurrencyFeesRequest setCurrencyFeesRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<TransactionModel>($"/v1/currencies/{currencyId}/fees?sdk=unity", setCurrencyFeesRequest);

		}

		/// <summary>
		/// Transfer currency
		/// </summary>
		///
		/// <remarks>
		/// Transfers an amount of currency to the provided wallet address or wallet address associated with the provided walletId. If you want to transfer to multiple wallets with different amounts and optional references in one API request, please see the Batch transfer currency documentation.  An optional reference may be included for the transfer. References are useful for identifying transfers intended to pay for items, trades, services and more.
		/// </remarks>
		/// <returns>TransactionModel</returns>
		public async UniTask<TransactionModel> TransferCurrency(string currencyId, TransferCurrencyRequest transferCurrencyRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<TransactionModel>($"/v1/currencies/{currencyId}/transfers?sdk=unity", transferCurrencyRequest);

		}
	}
}
