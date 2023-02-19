using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class AuthGame200ResponseAllOf
	{
		public string walletDecryptKey;
		public WalletModel wallet;
		public WalletModel fundingWallet;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public AuthGame200ResponseAllOf()
		{
		}

		public AuthGame200ResponseAllOf(string walletDecryptKey, WalletModel wallet, WalletModel fundingWallet)
		{
			this.walletDecryptKey = walletDecryptKey;
			this.wallet = wallet;
			this.fundingWallet = fundingWallet;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
