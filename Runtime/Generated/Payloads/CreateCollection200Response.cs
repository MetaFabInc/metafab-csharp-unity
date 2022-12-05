using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class CreateCollection200Response
	{
		public string id;
		public string gameId;
		public string contractId;
		public string updatedAt;
		public string createdAt;
		public CreateCollection200ResponseAllOfContract contract;

		public CreateCollection200Response(string id, string gameId, string contractId, string updatedAt, string createdAt, CreateCollection200ResponseAllOfContract contract)
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
