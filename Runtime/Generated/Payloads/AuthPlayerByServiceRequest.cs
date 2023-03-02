using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class AuthPlayerByServiceRequest
	{
		public string username;
		public string serviceCredential;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public AuthPlayerByServiceRequest()
		{
		}

		public AuthPlayerByServiceRequest(string username, string serviceCredential)
		{
			this.username = username;
			this.serviceCredential = serviceCredential;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
