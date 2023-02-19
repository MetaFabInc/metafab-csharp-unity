using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class CreateShopRequest
	{
		public string name;
		public string chain;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public CreateShopRequest()
		{
		}

		public CreateShopRequest(string name, string chain)
		{
			this.name = name;
			this.chain = chain;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
