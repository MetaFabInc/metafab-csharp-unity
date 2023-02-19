using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class CreateProfilePlayerRequest
	{
		public string username;
		public Dictionary<string, ProfilePermissionsValue> permissions;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public CreateProfilePlayerRequest()
		{
		}

		public CreateProfilePlayerRequest(string username, Dictionary<string, ProfilePermissionsValue> permissions)
		{
			this.username = username;
			this.permissions = permissions;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
