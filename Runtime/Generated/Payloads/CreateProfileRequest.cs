using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class CreateProfileRequest
	{
		public string username;
		public string password;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public CreateProfileRequest()
		{
		}

		public CreateProfileRequest(string username, string password)
		{
			this.username = username;
			this.password = password;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
