using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class TransferCurrencyRequest
	{
		public string address;
		public string walletId;
		public float amount;
		public float reference;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public TransferCurrencyRequest()
		{
		}

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
