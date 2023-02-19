using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class UpdateProfileRequest
	{
		public string currentPassword;
		public string newPassword;
		public bool? resetAccessToken;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public UpdateProfileRequest()
		{
		}

		public UpdateProfileRequest(string currentPassword, string newPassword, bool? resetAccessToken)
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
