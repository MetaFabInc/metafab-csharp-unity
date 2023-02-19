using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class BurnCollectionItemRequest
	{
		public int quantity;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public BurnCollectionItemRequest()
		{
		}

		public BurnCollectionItemRequest(int quantity)
		{
			this.quantity = quantity;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
