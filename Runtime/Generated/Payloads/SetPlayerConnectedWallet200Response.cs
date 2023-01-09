using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class SetPlayerConnectedWallet200Response
	{
		public string id;
		public string address;
		public TransactionModel transaction;

		public SetPlayerConnectedWallet200Response(string id, string address, TransactionModel transaction)
		{
			this.id = id;
			this.address = address;
			this.transaction = transaction;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
