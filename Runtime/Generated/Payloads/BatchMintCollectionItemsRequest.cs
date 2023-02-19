using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class BatchMintCollectionItemsRequest
	{
		public string address;
		public List<int> itemIds;
		public List<int> quantities;
		public string walletId;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public BatchMintCollectionItemsRequest()
		{
		}

		public BatchMintCollectionItemsRequest(string address, List<int> itemIds, List<int> quantities, string walletId)
		{
			this.address = address;
			this.itemIds = itemIds;
			this.quantities = quantities;
			this.walletId = walletId;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
