using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class BurnCollectionItemRequest
	{
		public int quantity;

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
