using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class ProfilePermissionsValue
	{
		public string chain;
		public List<string> scopes;
		public List<string> functions;
		public int erc20Limit;
		public Dictionary<string, int> erc1155Limits;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public ProfilePermissionsValue()
		{
		}

		public ProfilePermissionsValue(string chain, List<string> scopes, List<string> functions, int erc20Limit, Dictionary<string, int> erc1155Limits)
		{
			this.chain = chain;
			this.scopes = scopes;
			this.functions = functions;
			this.erc20Limit = erc20Limit;
			this.erc1155Limits = erc1155Limits;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
