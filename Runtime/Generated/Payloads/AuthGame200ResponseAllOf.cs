using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class AuthGame200ResponseAllOf
	{
		public WalletModel wallet;

		public AuthGame200ResponseAllOf(WalletModel wallet)
		{
			this.wallet = wallet;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
