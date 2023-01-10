using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class ProfileModel
	{
		public string id;
		public string walletId;
		public string connectedWalletId;
		public string username;
		public string accessToken;
		public string updatedAt;
		public string createdAt;

		public ProfileModel(string id, string walletId, string connectedWalletId, string username, string accessToken, string updatedAt, string createdAt)
		{
			this.id = id;
			this.walletId = walletId;
			this.connectedWalletId = connectedWalletId;
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
