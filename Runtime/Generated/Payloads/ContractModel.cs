using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class ContractModel
	{
		public string id;
		public string gameId;
		public string chain;
		public Object abi;
		public string type;
		public string address;
		public string updatedAt;
		public string createdAt;

		public ContractModel(string id, string gameId, string chain, Object abi, string type, string address, string updatedAt, string createdAt)
		{
			this.id = id;
			this.gameId = gameId;
			this.chain = chain;
			this.abi = abi;
			this.type = type;
			this.address = address;
			this.updatedAt = updatedAt;
			this.createdAt = createdAt;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
