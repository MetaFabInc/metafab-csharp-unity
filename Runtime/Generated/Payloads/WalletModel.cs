using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class WalletModel
	{
		public string id;
		public string address;

		public WalletModel(string id, string address)
		{
			this.id = id;
			this.address = address;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
