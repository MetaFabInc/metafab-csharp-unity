using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class GetCurrencies200ResponseInner
	{
		public string id;
		public string gameId;
		public string contractId;
		public string name;
		public string symbol;
		public int supplyCap;
		public string updatedAt;
		public string createdAt;
		public ContractModel contract;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public GetCurrencies200ResponseInner()
		{
		}

		public GetCurrencies200ResponseInner(string id, string gameId, string contractId, string name, string symbol, int supplyCap, string updatedAt, string createdAt, ContractModel contract)
		{
			this.id = id;
			this.gameId = gameId;
			this.contractId = contractId;
			this.name = name;
			this.symbol = symbol;
			this.supplyCap = supplyCap;
			this.updatedAt = updatedAt;
			this.createdAt = createdAt;
			this.contract = contract;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
