using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class CollectionItemAttributesInner
	{
		public string trait_type;
		public string value;

		public CollectionItemAttributesInner(string trait_type, string value)
		{
			this.trait_type = trait_type;
			this.value = value;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
