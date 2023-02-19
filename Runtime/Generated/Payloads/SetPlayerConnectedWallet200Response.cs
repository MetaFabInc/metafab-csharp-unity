using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class SetPlayerConnectedWallet200Response
	{
		public string id;
		public string address;
		public TransactionModel transaction;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public SetPlayerConnectedWallet200Response()
		{
		}

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
