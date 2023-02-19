using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class CreateCurrencyRequest
	{
		public string name;
		public string symbol;
		public float supplyCap;
		public string chain;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public CreateCurrencyRequest()
		{
		}

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
