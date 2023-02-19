using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class MintCollectionItemRequest
	{
		public string address;
		public int quantity;
		public string walletId;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public MintCollectionItemRequest()
		{
		}

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
