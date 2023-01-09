using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class SetPlayerConnectedWalletRequest
	{
		public string address;
		public int nonce;
		public string signature;
		public string chain;

		public SetPlayerConnectedWalletRequest(string address, int nonce, string signature, string chain)
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
