using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class CollectionItemAttributesInnerValue
	{


		public CollectionItemAttributesInnerValue()
		{
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
