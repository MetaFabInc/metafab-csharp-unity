using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class TransactionModel
	{
		public string id;
		public string contractId;
		public string walletId;
		public string function;
		public Object args;
		public string hash;
		public string updatedAt;
		public string createdAt;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public TransactionModel()
		{
		}

		public TransactionModel(string id, string contractId, string walletId, string function, Object args, string hash, string updatedAt, string createdAt)
		{
			this.id = id;
			this.contractId = contractId;
			this.walletId = walletId;
			this.function = function;
			this.args = args;
			this.hash = hash;
			this.updatedAt = updatedAt;
			this.createdAt = createdAt;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
