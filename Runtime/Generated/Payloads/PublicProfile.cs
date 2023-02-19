using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class PublicProfile
	{
		public string id;
		public string walletId;
		public string username;
		public string updatedAt;
		public string createdAt;
		public PublicPlayerCustodialWallet custodialWallet;
		public PublicPlayerCustodialWallet wallet;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public PublicProfile()
		{
		}

		public PublicProfile(string id, string walletId, string username, string updatedAt, string createdAt, PublicPlayerCustodialWallet custodialWallet, PublicPlayerCustodialWallet wallet)
		{
			this.id = id;
			this.walletId = walletId;
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
