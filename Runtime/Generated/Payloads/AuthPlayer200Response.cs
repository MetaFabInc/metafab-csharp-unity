using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class AuthPlayer200Response
	{
		public string id;
		public string gameId;
		public string profileId;
		public string walletId;
		public string connectedWalletId;
		public string username;
		public string accessToken;
		public string updatedAt;
		public string createdAt;
		public WalletModel wallet;

		public AuthPlayer200Response(string id, string gameId, string profileId, string walletId, string connectedWalletId, string username, string accessToken, string updatedAt, string createdAt, WalletModel wallet)
		{
			this.id = id;
			this.gameId = gameId;
			this.profileId = profileId;
			this.walletId = walletId;
			this.connectedWalletId = connectedWalletId;
			this.username = username;
			this.accessToken = accessToken;
			this.updatedAt = updatedAt;
			this.createdAt = createdAt;
			this.wallet = wallet;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
