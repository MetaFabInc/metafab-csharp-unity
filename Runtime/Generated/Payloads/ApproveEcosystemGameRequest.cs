using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class ApproveEcosystemGameRequest
	{
		public string gameId;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public ApproveEcosystemGameRequest()
		{
		}

		public ApproveEcosystemGameRequest(string gameId)
		{
			this.gameId = gameId;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
