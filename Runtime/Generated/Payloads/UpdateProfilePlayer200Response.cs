using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class UpdateProfilePlayer200Response
	{
		public string id;
		public string gameId;
		public string walletId;
		public string connectedWalletId;
		public string profileId;
		public string username;
		public string accessToken;
		public Object profilePermissions;
		public string updatedAt;
		public string createdAt;
		public WalletModel wallet;
		public WalletModel custodialWallet;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public UpdateProfilePlayer200Response()
		{
		}

		public UpdateProfilePlayer200Response(string id, string gameId, string walletId, string connectedWalletId, string profileId, string username, string accessToken, Object profilePermissions, string updatedAt, string createdAt, WalletModel wallet, WalletModel custodialWallet)
		{
			this.id = id;
			this.gameId = gameId;
			this.walletId = walletId;
			this.connectedWalletId = connectedWalletId;
			this.profileId = profileId;
			this.username = username;
			this.accessToken = accessToken;
			this.profilePermissions = profilePermissions;
			this.updatedAt = updatedAt;
			this.createdAt = createdAt;
			this.wallet = wallet;
			this.custodialWallet = custodialWallet;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
