using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class AuthProfile200Response
	{
		public string id;
		public string ecosystemId;
		public string walletId;
		public string connectedWalletId;
		public string username;
		public string accessToken;
		public string updatedAt;
		public string createdAt;
		public string walletDecryptKey;
		public WalletModel wallet;
		public WalletModel custodialWallet;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public AuthProfile200Response()
		{
		}

		public AuthProfile200Response(string id, string ecosystemId, string walletId, string connectedWalletId, string username, string accessToken, string updatedAt, string createdAt, string walletDecryptKey, WalletModel wallet, WalletModel custodialWallet)
		{
			this.id = id;
			this.ecosystemId = ecosystemId;
			this.walletId = walletId;
			this.connectedWalletId = connectedWalletId;
			this.username = username;
			this.accessToken = accessToken;
			this.updatedAt = updatedAt;
			this.createdAt = createdAt;
			this.walletDecryptKey = walletDecryptKey;
			this.wallet = wallet;
			this.custodialWallet = custodialWallet;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
