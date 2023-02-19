using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class SetPlayerConnectedWalletRequest
	{
		public string address;
		public int nonce;
		public string signature;
		public string chain;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public SetPlayerConnectedWalletRequest()
		{
		}

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
