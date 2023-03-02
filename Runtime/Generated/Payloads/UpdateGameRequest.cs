using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class UpdateGameRequest
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
		public string discordClientId;
		public bool? resetPublishedKey;
		public bool? resetSecretKey;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public UpdateGameRequest()
		{
		}

		public UpdateGameRequest(string name, string email, string currentPassword, string newPassword, Dictionary<string, string> rpcs, List<string> redirectUris, string iconImageBase64, string coverImageBase64, string primaryColorHex, string discordClientId, bool? resetPublishedKey, bool? resetSecretKey)
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
			this.discordClientId = discordClientId;
			this.resetPublishedKey = resetPublishedKey;
			this.resetSecretKey = resetSecretKey;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
