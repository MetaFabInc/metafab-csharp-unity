using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class AuthPlayer200ResponseAllOf
	{
		public string walletDecryptKey;
		public WalletModel wallet;
		public WalletModel custodialWallet;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public AuthPlayer200ResponseAllOf()
		{
		}

		public AuthPlayer200ResponseAllOf(string walletDecryptKey, WalletModel wallet, WalletModel custodialWallet)
		{
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
