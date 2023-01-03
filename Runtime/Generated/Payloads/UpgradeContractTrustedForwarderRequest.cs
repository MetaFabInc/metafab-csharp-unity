using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class UpgradeContractTrustedForwarderRequest
	{
		public string forwarderAddress;

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
