using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class CreateShopRequest
	{
		public string chain;

		public CreateShopRequest(string chain)
		{
			this.chain = chain;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
