using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class BurnCurrencyRequest
	{
		public float amount;

		public BurnCurrencyRequest(float amount)
		{
			this.amount = amount;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
