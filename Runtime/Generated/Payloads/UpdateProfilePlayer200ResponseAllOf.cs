using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class UpdateProfilePlayer200ResponseAllOf
	{
		public WalletModel wallet;
		public WalletModel custodialWallet;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public UpdateProfilePlayer200ResponseAllOf()
		{
		}

		public UpdateProfilePlayer200ResponseAllOf(WalletModel wallet, WalletModel custodialWallet)
		{
			this.wallet = wallet;
			this.custodialWallet = custodialWallet;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
