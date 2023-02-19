using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class RevokeCollectionRoleRequest
	{
		public string role;
		public string address;
		public List<string> walletId;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public RevokeCollectionRoleRequest()
		{
		}

		public RevokeCollectionRoleRequest(string role, string address, List<string> walletId)
		{
			this.role = role;
			this.address = address;
			this.walletId = walletId;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
