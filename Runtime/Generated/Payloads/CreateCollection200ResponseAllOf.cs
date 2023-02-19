using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class CreateCollection200ResponseAllOf
	{
		public CreateCollection200ResponseAllOfContract contract;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public CreateCollection200ResponseAllOf()
		{
		}

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
