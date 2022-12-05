using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class AuthGame200Response
	{
		public string id;
		public string walletId;
		public string fundingWalletId;
		public string email;
		public string name;
		public Object rpcs;
		public string publishedKey;
		public string secretKey;
		public bool? verified;
		public string updatedAt;
		public string createdAt;
		public WalletModel wallet;
		public WalletModel fundingWallet;

		public AuthGame200Response(string id, string walletId, string fundingWalletId, string email, string name, Object rpcs, string publishedKey, string secretKey, bool? verified, string updatedAt, string createdAt, WalletModel wallet, WalletModel fundingWallet)
		{
			this.id = id;
			this.walletId = walletId;
			this.fundingWalletId = fundingWalletId;
			this.email = email;
			this.name = name;
			this.rpcs = rpcs;
			this.publishedKey = publishedKey;
			this.secretKey = secretKey;
			this.verified = verified;
			this.updatedAt = updatedAt;
			this.createdAt = createdAt;
			this.wallet = wallet;
			this.fundingWallet = fundingWallet;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
