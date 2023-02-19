using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class CollectionItemAttributesInner
	{
		public string trait_type;
		public string value;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public CollectionItemAttributesInner()
		{
		}

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
