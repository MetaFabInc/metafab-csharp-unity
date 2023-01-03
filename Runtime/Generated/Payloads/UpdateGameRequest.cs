using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class UpdateGameRequest
	{
		public string name;
		public string email;
		public string currentPassword;
		public string newPassword;
		public Dictionary<string, string> rpcs;
		public List<string> redirectUris;
		public string iconImageBase64;
		public string coverImageBase64;
		public string primaryColorHex;
		public bool? resetPublishedKey;
		public bool? resetSecretKey;

		public UpdateGameRequest(string name, string email, string currentPassword, string newPassword, Dictionary<string, string> rpcs, List<string> redirectUris, string iconImageBase64, string coverImageBase64, string primaryColorHex, bool? resetPublishedKey, bool? resetSecretKey)
		{
			this.name = name;
			this.email = email;
			this.currentPassword = currentPassword;
			this.newPassword = newPassword;
			this.rpcs = rpcs;
			this.redirectUris = redirectUris;
			this.iconImageBase64 = iconImageBase64;
			this.coverImageBase64 = coverImageBase64;
			this.primaryColorHex = primaryColorHex;
			this.resetPublishedKey = resetPublishedKey;
			this.resetSecretKey = resetSecretKey;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
