using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class AuthGame200ResponseAllOf1
	{
		public WalletModel fundingWallet;

		public AuthGame200ResponseAllOf1(WalletModel fundingWallet)
		{
			this.fundingWallet = fundingWallet;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
