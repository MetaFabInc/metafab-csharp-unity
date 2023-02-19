using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class CreateCollection200ResponseAllOfContractAllOf
	{
		public List<TransactionModel> transactions;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public CreateCollection200ResponseAllOfContractAllOf()
		{
		}

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
