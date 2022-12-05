using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class CreatePlayerRequest
	{
		public string username;
		public string password;

		public CreatePlayerRequest(string username, string password)
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
