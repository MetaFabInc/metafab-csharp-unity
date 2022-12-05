using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class UpdatePlayerRequest
	{
		public string currentPassword;
		public string newPassword;
		public bool? resetAccessToken;

		public UpdatePlayerRequest(string currentPassword, string newPassword, bool? resetAccessToken)
		{
			this.currentPassword = currentPassword;
			this.newPassword = newPassword;
			this.resetAccessToken = resetAccessToken;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
