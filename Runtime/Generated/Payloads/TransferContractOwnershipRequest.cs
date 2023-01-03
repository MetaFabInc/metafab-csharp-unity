using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class TransferContractOwnershipRequest
	{
		public string ownerAddress;

		public TransferContractOwnershipRequest(string ownerAddress)
		{
			this.ownerAddress = ownerAddress;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
