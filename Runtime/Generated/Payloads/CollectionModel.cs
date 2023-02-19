using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class CollectionModel
	{
		public string id;
		public string gameId;
		public string contractId;
		public string name;
		public string updatedAt;
		public string createdAt;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public CollectionModel()
		{
		}

		public CollectionModel(string id, string gameId, string contractId, string name, string updatedAt, string createdAt)
		{
			this.id = id;
			this.gameId = gameId;
			this.contractId = contractId;
			this.name = name;
			this.updatedAt = updatedAt;
			this.createdAt = createdAt;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
