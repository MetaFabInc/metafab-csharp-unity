using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class CreateCollectionItemRequestAttributesInner
	{
		public string trait_type;
		public Object value;

		public CreateCollectionItemRequestAttributesInner(string trait_type, Object value)
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
