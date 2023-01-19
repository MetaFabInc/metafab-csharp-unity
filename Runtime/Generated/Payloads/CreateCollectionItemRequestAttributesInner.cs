using System;
using UnityEngine;
using System.Collections.Generic;


 
namespace MetafabSdk
{
	[Serializable]
	public class CreateCollectionItemRequestAttributesInner
	{
		public string trait_type;
		public string value;

		public CreateCollectionItemRequestAttributesInner(string trait_type, string value)
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
