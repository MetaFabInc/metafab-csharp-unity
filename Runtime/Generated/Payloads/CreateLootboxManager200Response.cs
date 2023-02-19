using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class CreateLootboxManager200Response
	{
		public string id;
		public string gameId;
		public string contractId;
		public string name;
		public string updatedAt;
		public string createdAt;
		public CreateCollection200ResponseAllOfContract contract;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public CreateLootboxManager200Response()
		{
		}

		public CreateLootboxManager200Response(string id, string gameId, string contractId, string name, string updatedAt, string createdAt, CreateCollection200ResponseAllOfContract contract)
		{
			this.id = id;
			this.gameId = gameId;
			this.contractId = contractId;
			this.name = name;
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
