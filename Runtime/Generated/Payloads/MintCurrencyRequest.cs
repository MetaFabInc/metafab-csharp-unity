using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class MintCurrencyRequest
	{
		public float amount;
		public string address;
		public string walletId;

		public MintCurrencyRequest(float amount, string address, string walletId)
		{
			this.amount = amount;
			this.address = address;
			this.walletId = walletId;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
