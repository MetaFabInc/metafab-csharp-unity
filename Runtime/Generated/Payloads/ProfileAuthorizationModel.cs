using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class ProfileAuthorizationModel
	{
		public string id;
		public string profileId;
		public string playerId;
		public Object permissions;
		public string updatedAt;
		public string createdAt;

		public ProfileAuthorizationModel(string id, string profileId, string playerId, Object permissions, string updatedAt, string createdAt)
		{
			this.id = id;
			this.profileId = profileId;
			this.playerId = playerId;
			this.permissions = permissions;
			this.updatedAt = updatedAt;
			this.createdAt = createdAt;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
