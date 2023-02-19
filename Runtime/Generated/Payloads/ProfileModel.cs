using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class ProfileModel
	{
		public string id;
		public string ecosystemId;
		public string walletId;
		public string connectedWalletId;
		public string username;
		public string accessToken;
		public string updatedAt;
		public string createdAt;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public ProfileModel()
		{
		}

		public ProfileModel(string id, string ecosystemId, string walletId, string connectedWalletId, string username, string accessToken, string updatedAt, string createdAt)
		{
			this.id = id;
			this.ecosystemId = ecosystemId;
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
