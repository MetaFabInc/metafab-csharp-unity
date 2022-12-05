using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class BatchTransferCollectionItemsRequest
	{
		public List<string> addresses;
		public List<string> walletIds;
		public List<int> itemIds;
		public List<int> quantities;

		public BatchTransferCollectionItemsRequest(List<string> addresses, List<string> walletIds, List<int> itemIds, List<int> quantities)
		{
			this.addresses = addresses;
			this.walletIds = walletIds;
			this.itemIds = itemIds;
			this.quantities = quantities;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
