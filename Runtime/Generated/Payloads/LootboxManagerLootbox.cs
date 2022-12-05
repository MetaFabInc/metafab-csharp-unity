using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class LootboxManagerLootbox
	{
		public int id;
		public string inputCollection;
		public List<int> inputCollectionItemIds;
		public List<int> inputCollectionItemAmounts;
		public string outputCollection;
		public List<int> outputCollectionItemIds;
		public List<int> outputCollectionItemAmounts;
		public List<int> outputCollectionItemWeights;
		public int outputTotalItems;
		public int lastUpdatedAt;

		public LootboxManagerLootbox(int id, string inputCollection, List<int> inputCollectionItemIds, List<int> inputCollectionItemAmounts, string outputCollection, List<int> outputCollectionItemIds, List<int> outputCollectionItemAmounts, List<int> outputCollectionItemWeights, int outputTotalItems, int lastUpdatedAt)
		{
			this.id = id;
			this.inputCollection = inputCollection;
			this.inputCollectionItemIds = inputCollectionItemIds;
			this.inputCollectionItemAmounts = inputCollectionItemAmounts;
			this.outputCollection = outputCollection;
			this.outputCollectionItemIds = outputCollectionItemIds;
			this.outputCollectionItemAmounts = outputCollectionItemAmounts;
			this.outputCollectionItemWeights = outputCollectionItemWeights;
			this.outputTotalItems = outputTotalItems;
			this.lastUpdatedAt = lastUpdatedAt;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
