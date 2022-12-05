using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class GetLootboxManagers200ResponseInner
	{
		public string id;
		public string gameId;
		public string contractId;
		public string updatedAt;
		public string createdAt;
		public ContractModel contract;

		public GetLootboxManagers200ResponseInner(string id, string gameId, string contractId, string updatedAt, string createdAt, ContractModel contract)
		{
			this.id = id;
			this.gameId = gameId;
			this.contractId = contractId;
			this.updatedAt = updatedAt;
			this.createdAt = createdAt;
			this.contract = contract;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
