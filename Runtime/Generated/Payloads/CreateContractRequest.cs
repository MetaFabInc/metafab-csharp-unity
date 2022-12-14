using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class CreateContractRequest
	{
		public string address;
		public string forwarderAddress;
		public string abi;
		public string chain;

		public CreateContractRequest(string address, string forwarderAddress, string abi, string chain)
		{
			this.address = address;
			this.forwarderAddress = forwarderAddress;
			this.abi = abi;
			this.chain = chain;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
