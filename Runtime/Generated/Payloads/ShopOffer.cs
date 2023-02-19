using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class ShopOffer
	{
		public int id;
		public string inputCollection;
		public List<int> inputCollectionItemIds;
		public List<int> inputCollectionItemAmounts;
		public string inputCurrency;
		public float inputCurrencyAmount;
		public string outputCollection;
		public List<int> outputCollectionItemIds;
		public List<int> outputCollectionItemAmounts;
		public string outputCurrency;
		public float outputCurrencyAmount;
		public int uses;
		public int maxUses;
		public int lastUpdatedAt;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public ShopOffer()
		{
		}

		public ShopOffer(int id, string inputCollection, List<int> inputCollectionItemIds, List<int> inputCollectionItemAmounts, string inputCurrency, float inputCurrencyAmount, string outputCollection, List<int> outputCollectionItemIds, List<int> outputCollectionItemAmounts, string outputCurrency, float outputCurrencyAmount, int uses, int maxUses, int lastUpdatedAt)
		{
			this.id = id;
			this.inputCollection = inputCollection;
			this.inputCollectionItemIds = inputCollectionItemIds;
			this.inputCollectionItemAmounts = inputCollectionItemAmounts;
			this.inputCurrency = inputCurrency;
			this.inputCurrencyAmount = inputCurrencyAmount;
			this.outputCollection = outputCollection;
			this.outputCollectionItemIds = outputCollectionItemIds;
			this.outputCollectionItemAmounts = outputCollectionItemAmounts;
			this.outputCurrency = outputCurrency;
			this.outputCurrencyAmount = outputCurrencyAmount;
			this.uses = uses;
			this.maxUses = maxUses;
			this.lastUpdatedAt = lastUpdatedAt;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
