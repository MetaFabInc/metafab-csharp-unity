using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class SetCurrencyFeesRequest
	{
		public string recipientAddress;
		public float basisPoints;
		public float fixedAmount;
		public float capAmount;

		public SetCurrencyFeesRequest(string recipientAddress, float basisPoints, float fixedAmount, float capAmount)
		{
			this.recipientAddress = recipientAddress;
			this.basisPoints = basisPoints;
			this.fixedAmount = fixedAmount;
			this.capAmount = capAmount;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
