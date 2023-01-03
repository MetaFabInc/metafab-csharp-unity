using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class CreateCollection200ResponseAllOfContract
	{
		public string id;
		public string gameId;
		public string chain;
		public Object abi;
		public string type;
		public string address;
		public string forwarderAddress;
		public string updatedAt;
		public string createdAt;
		public List<TransactionModel> transactions;

		public CreateCollection200ResponseAllOfContract(string id, string gameId, string chain, Object abi, string type, string address, string forwarderAddress, string updatedAt, string createdAt, List<TransactionModel> transactions)
		{
			this.id = id;
			this.gameId = gameId;
			this.chain = chain;
			this.abi = abi;
			this.type = type;
			this.address = address;
			this.forwarderAddress = forwarderAddress;
			this.updatedAt = updatedAt;
			this.createdAt = createdAt;
			this.transactions = transactions;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
