using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class BurnCurrencyRequest
	{
		public float amount;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public BurnCurrencyRequest()
		{
		}

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
