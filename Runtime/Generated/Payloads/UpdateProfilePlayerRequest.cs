using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class UpdateProfilePlayerRequest
	{
		public Dictionary<string, ProfilePermissionsValue> permissions;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public UpdateProfilePlayerRequest()
		{
		}

		public UpdateProfilePlayerRequest(Dictionary<string, ProfilePermissionsValue> permissions)
		{
			this.permissions = permissions;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
