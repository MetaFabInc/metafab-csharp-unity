using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class GetCollections200ResponseInnerAllOf
	{
		public ContractModel contract;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public GetCollections200ResponseInnerAllOf()
		{
		}

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
