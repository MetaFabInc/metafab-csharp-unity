using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class GrantCollectionRoleRequest
	{
		public string role;
		public string address;
		public List<string> walletId;

		public GrantCollectionRoleRequest(string role, string address, List<string> walletId)
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
