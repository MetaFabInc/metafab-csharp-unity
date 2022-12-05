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
		public bool? resetPublishedKey;
		public bool? resetSecretKey;

		public UpdateGameRequest(string name, string email, string currentPassword, string newPassword, Dictionary<string, string> rpcs, bool? resetPublishedKey, bool? resetSecretKey)
		{
			this.name = name;
			this.email = email;
			this.currentPassword = currentPassword;
			this.newPassword = newPassword;
			this.rpcs = rpcs;
			this.resetPublishedKey = resetPublishedKey;
			this.resetSecretKey = resetSecretKey;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
