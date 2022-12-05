using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class MintCollectionItemRequest
	{
		public string address;
		public int quantity;
		public string walletId;

		public MintCollectionItemRequest(string address, int quantity, string walletId)
		{
			this.address = address;
			this.quantity = quantity;
			this.walletId = walletId;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
