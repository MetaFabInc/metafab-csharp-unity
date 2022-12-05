using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class CreateCollection200ResponseAllOf
	{
		public CreateCollection200ResponseAllOfContract contract;

		public CreateCollection200ResponseAllOf(CreateCollection200ResponseAllOfContract contract)
		{
			this.contract = contract;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
