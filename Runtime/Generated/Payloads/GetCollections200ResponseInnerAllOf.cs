using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class GetCollections200ResponseInnerAllOf
	{
		public ContractModel contract;

		public GetCollections200ResponseInnerAllOf(ContractModel contract)
		{
			this.contract = contract;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
