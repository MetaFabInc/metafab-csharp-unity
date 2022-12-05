using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class TransferCurrencyRequest
	{
		public string address;
		public string walletId;
		public float amount;
		public float reference;

		public TransferCurrencyRequest(string address, string walletId, float amount, float reference)
		{
			this.address = address;
			this.walletId = walletId;
			this.amount = amount;
			this.reference = reference;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
