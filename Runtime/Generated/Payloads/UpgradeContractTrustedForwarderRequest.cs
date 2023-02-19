using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class UpgradeContractTrustedForwarderRequest
	{
		public string forwarderAddress;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public UpgradeContractTrustedForwarderRequest()
		{
		}

		public UpgradeContractTrustedForwarderRequest(string forwarderAddress)
		{
			this.forwarderAddress = forwarderAddress;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
