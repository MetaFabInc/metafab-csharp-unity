using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class TransferCollectionItemRequest
	{
		public string address;
		public List<string> walletId;
		public int quantity;

		public TransferCollectionItemRequest(string address, List<string> walletId, int quantity)
		{
			this.address = address;
			this.walletId = walletId;
			this.quantity = quantity;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
