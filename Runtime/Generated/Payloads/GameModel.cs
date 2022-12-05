using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class GameModel
	{
		public string id;
		public string walletId;
		public string fundingWalletId;
		public string email;
		public string name;
		public Object rpcs;
		public string publishedKey;
		public string secretKey;
		public bool? verified;
		public string updatedAt;
		public string createdAt;

		public GameModel(string id, string walletId, string fundingWalletId, string email, string name, Object rpcs, string publishedKey, string secretKey, bool? verified, string updatedAt, string createdAt)
		{
			this.id = id;
			this.walletId = walletId;
			this.fundingWalletId = fundingWalletId;
			this.email = email;
			this.name = name;
			this.rpcs = rpcs;
			this.publishedKey = publishedKey;
			this.secretKey = secretKey;
			this.verified = verified;
			this.updatedAt = updatedAt;
			this.createdAt = createdAt;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
