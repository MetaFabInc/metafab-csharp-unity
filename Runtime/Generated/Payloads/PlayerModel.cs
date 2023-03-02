using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class PlayerModel
	{
		public string id;
		public string gameId;
		public string walletId;
		public string connectedWalletId;
		public string profileId;
		public string username;
		public string accessToken;
		public Object profilePermissions;
		public string serviceAuthLookup;
		public string accessTokenExpiresAt;
		public string updatedAt;
		public string createdAt;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public PlayerModel()
		{
		}

		public PlayerModel(string id, string gameId, string walletId, string connectedWalletId, string profileId, string username, string accessToken, Object profilePermissions, string serviceAuthLookup, string accessTokenExpiresAt, string updatedAt, string createdAt)
		{
			this.id = id;
			this.gameId = gameId;
			this.walletId = walletId;
			this.connectedWalletId = connectedWalletId;
			this.profileId = profileId;
			this.username = username;
			this.accessToken = accessToken;
			this.profilePermissions = profilePermissions;
			this.serviceAuthLookup = serviceAuthLookup;
			this.accessTokenExpiresAt = accessTokenExpiresAt;
			this.updatedAt = updatedAt;
			this.createdAt = createdAt;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
