using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class SetCollectionApprovalRequest
	{
		public bool? approved;
		public string address;
		public List<string> walletId;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public SetCollectionApprovalRequest()
		{
		}

		public SetCollectionApprovalRequest(bool? approved, string address, List<string> walletId)
		{
			this.approved = approved;
			this.address = address;
			this.walletId = walletId;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
