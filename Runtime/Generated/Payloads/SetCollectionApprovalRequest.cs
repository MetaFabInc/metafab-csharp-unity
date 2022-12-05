using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class SetCollectionApprovalRequest
	{
		public bool? approved;
		public string address;
		public List<string> walletId;

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
