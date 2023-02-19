using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class PublicPlayer
	{
		public string id;
		public string gameId;
		public string walletId;
		public string connectedWalletId;
		public string profileId;
		public string username;
		public string updatedAt;
		public string createdAt;
		public PublicPlayerCustodialWallet custodialWallet;
		public PublicPlayerCustodialWallet wallet;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public PublicPlayer()
		{
		}

		public PublicPlayer(string id, string gameId, string walletId, string connectedWalletId, string profileId, string username, string updatedAt, string createdAt, PublicPlayerCustodialWallet custodialWallet, PublicPlayerCustodialWallet wallet)
		{
			this.id = id;
			this.gameId = gameId;
			this.walletId = walletId;
			this.connectedWalletId = connectedWalletId;
			this.profileId = profileId;
			this.username = username;
			this.updatedAt = updatedAt;
			this.createdAt = createdAt;
			this.custodialWallet = custodialWallet;
			this.wallet = wallet;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
