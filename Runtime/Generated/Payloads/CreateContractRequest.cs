using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class CreateContractRequest
	{
		public string address;
		public string forwarderAddress;
		public string abi;
		public string chain;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public CreateContractRequest()
		{
		}

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
