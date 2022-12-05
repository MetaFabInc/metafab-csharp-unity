using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class CreateCurrencyRequest
	{
		public string name;
		public string symbol;
		public float supplyCap;
		public string chain;

		public CreateCurrencyRequest(string name, string symbol, float supplyCap, string chain)
		{
			this.name = name;
			this.symbol = symbol;
			this.supplyCap = supplyCap;
			this.chain = chain;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
