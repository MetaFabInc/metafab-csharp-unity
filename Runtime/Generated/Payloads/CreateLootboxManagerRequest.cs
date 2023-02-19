using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class CreateLootboxManagerRequest
	{
		public string name;
		public string chain;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public CreateLootboxManagerRequest()
		{
		}

		public CreateLootboxManagerRequest(string name, string chain)
		{
			this.name = name;
			this.chain = chain;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
