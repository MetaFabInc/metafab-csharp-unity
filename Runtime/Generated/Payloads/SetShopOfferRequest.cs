using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class SetShopOfferRequest
	{
		public int id;
		public string inputCollectionAddress;
		public string inputCollectionId;
		public List<int> inputCollectionItemIds;
		public List<int> inputCollectionItemAmounts;
		public string inputCurrencyAddress;
		public string inputCurrencyId;
		public float inputCurrencyAmount;
		public string outputCollectionAddress;
		public string outputCollectionId;
		public List<int> outputCollectionItemIds;
		public List<int> outputCollectionItemAmounts;
		public string outputCurrencyAddress;
		public string outputCurrencyId;
		public float outputCurrencyAmount;
		public int maxUses;

		public SetShopOfferRequest(int id, string inputCollectionAddress, string inputCollectionId, List<int> inputCollectionItemIds, List<int> inputCollectionItemAmounts, string inputCurrencyAddress, string inputCurrencyId, float inputCurrencyAmount, string outputCollectionAddress, string outputCollectionId, List<int> outputCollectionItemIds, List<int> outputCollectionItemAmounts, string outputCurrencyAddress, string outputCurrencyId, float outputCurrencyAmount, int maxUses)
		{
			this.id = id;
			this.inputCollectionAddress = inputCollectionAddress;
			this.inputCollectionId = inputCollectionId;
			this.inputCollectionItemIds = inputCollectionItemIds;
			this.inputCollectionItemAmounts = inputCollectionItemAmounts;
			this.inputCurrencyAddress = inputCurrencyAddress;
			this.inputCurrencyId = inputCurrencyId;
			this.inputCurrencyAmount = inputCurrencyAmount;
			this.outputCollectionAddress = outputCollectionAddress;
			this.outputCollectionId = outputCollectionId;
			this.outputCollectionItemIds = outputCollectionItemIds;
			this.outputCollectionItemAmounts = outputCollectionItemAmounts;
			this.outputCurrencyAddress = outputCurrencyAddress;
			this.outputCurrencyId = outputCurrencyId;
			this.outputCurrencyAmount = outputCurrencyAmount;
			this.maxUses = maxUses;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
