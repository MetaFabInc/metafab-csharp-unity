using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class PlayerModel
	{
		public string id;
		public string gameId;
		public string walletId;
		public string connectedWalletId;
		public string profileId;
		public string profileAuthorizationId;
		public string username;
		public string accessToken;
		public string updatedAt;
		public string createdAt;

		public PlayerModel(string id, string gameId, string walletId, string connectedWalletId, string profileId, string profileAuthorizationId, string username, string accessToken, string updatedAt, string createdAt)
		{
			this.id = id;
			this.gameId = gameId;
			this.walletId = walletId;
			this.connectedWalletId = connectedWalletId;
			this.profileId = profileId;
			this.profileAuthorizationId = profileAuthorizationId;
			this.username = username;
			this.accessToken = accessToken;
			this.updatedAt = updatedAt;
			this.createdAt = createdAt;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
