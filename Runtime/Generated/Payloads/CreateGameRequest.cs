using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class CreateGameRequest
	{
		public string name;
		public string email;
		public string password;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public CreateGameRequest()
		{
		}

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
