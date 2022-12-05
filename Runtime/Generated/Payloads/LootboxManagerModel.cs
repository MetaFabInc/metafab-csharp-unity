using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class LootboxManagerModel
	{
		public string id;
		public string gameId;
		public string contractId;
		public string updatedAt;
		public string createdAt;

		public LootboxManagerModel(string id, string gameId, string contractId, string updatedAt, string createdAt)
		{
			this.id = id;
			this.gameId = gameId;
			this.contractId = contractId;
			this.updatedAt = updatedAt;
			this.createdAt = createdAt;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
