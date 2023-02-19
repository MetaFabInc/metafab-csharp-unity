using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class TransferContractOwnershipRequest
	{
		public string ownerAddress;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public TransferContractOwnershipRequest()
		{
		}

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
