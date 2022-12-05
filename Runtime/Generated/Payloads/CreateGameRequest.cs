using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class CreateGameRequest
	{
		public string name;
		public string email;
		public string password;

		public CreateGameRequest(string name, string email, string password)
		{
			this.name = name;
			this.email = email;
			this.password = password;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
