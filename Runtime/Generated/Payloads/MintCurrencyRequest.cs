using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class MintCurrencyRequest
	{
		public float amount;
		public string address;
		public string walletId;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public MintCurrencyRequest()
		{
		}

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
