using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class CreateCollection200ResponseAllOfContractAllOf
	{
		public List<TransactionModel> transactions;

		public CreateCollection200ResponseAllOfContractAllOf(List<TransactionModel> transactions)
		{
			this.transactions = transactions;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
