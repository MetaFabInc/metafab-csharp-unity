using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class RemovePlayerConnectedWalletRequest
	{
		public string address;
		public int nonce;
		public string signature;
		public string chain;

		public RemovePlayerConnectedWalletRequest(string address, int nonce, string signature, string chain)
		{
			this.address = address;
			this.nonce = nonce;
			this.signature = signature;
			this.chain = chain;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
