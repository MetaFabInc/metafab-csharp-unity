using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class EcosystemGameModel
	{
		public string id;
		public string ecosystemId;
		public string gameId;
		public string updatedAt;
		public string createdAt;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public EcosystemGameModel()
		{
		}

		public EcosystemGameModel(string id, string ecosystemId, string gameId, string updatedAt, string createdAt)
		{
			this.id = id;
			this.ecosystemId = ecosystemId;
			this.gameId = gameId;
			this.updatedAt = updatedAt;
			this.createdAt = createdAt;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
