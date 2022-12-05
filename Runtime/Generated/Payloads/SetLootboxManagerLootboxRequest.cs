using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class SetLootboxManagerLootboxRequest
	{
		public int id;
		public string inputCollectionAddress;
		public string inputCollectionId;
		public List<int> inputCollectionItemIds;
		public List<int> inputCollectionItemAmounts;
		public string outputCollectionAddress;
		public string outputCollectionId;
		public List<int> outputCollectionItemIds;
		public List<int> outputCollectionItemAmounts;
		public List<int> outputCollectionItemWeights;
		public int outputTotalItems;

		public SetLootboxManagerLootboxRequest(int id, string inputCollectionAddress, string inputCollectionId, List<int> inputCollectionItemIds, List<int> inputCollectionItemAmounts, string outputCollectionAddress, string outputCollectionId, List<int> outputCollectionItemIds, List<int> outputCollectionItemAmounts, List<int> outputCollectionItemWeights, int outputTotalItems)
		{
			this.id = id;
			this.inputCollectionAddress = inputCollectionAddress;
			this.inputCollectionId = inputCollectionId;
			this.inputCollectionItemIds = inputCollectionItemIds;
			this.inputCollectionItemAmounts = inputCollectionItemAmounts;
			this.outputCollectionAddress = outputCollectionAddress;
			this.outputCollectionId = outputCollectionId;
			this.outputCollectionItemIds = outputCollectionItemIds;
			this.outputCollectionItemAmounts = outputCollectionItemAmounts;
			this.outputCollectionItemWeights = outputCollectionItemWeights;
			this.outputTotalItems = outputTotalItems;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
