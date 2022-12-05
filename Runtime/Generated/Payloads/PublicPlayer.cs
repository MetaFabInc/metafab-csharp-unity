using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class PublicPlayer
	{
		public string id;
		public string gameId;
		public string walletId;
		public string username;
		public string updatedAt;
		public string createdAt;
		public PublicPlayerWallet wallet;

		public PublicPlayer(string id, string gameId, string walletId, string username, string updatedAt, string createdAt, PublicPlayerWallet wallet)
		{
			this.id = id;
			this.gameId = gameId;
			this.walletId = walletId;
			this.username = username;
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
