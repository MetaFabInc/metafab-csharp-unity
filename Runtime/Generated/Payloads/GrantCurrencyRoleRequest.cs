using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class GrantCurrencyRoleRequest
	{
		public string role;
		public string address;
		public string walletId;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public GrantCurrencyRoleRequest()
		{
		}

		public GrantCurrencyRoleRequest(string role, string address, string walletId)
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
