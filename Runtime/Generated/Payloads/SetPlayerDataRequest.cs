using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class SetPlayerDataRequest
	{
		public Object protectedData;
		public Object publicData;

		public SetPlayerDataRequest(Object protectedData, Object publicData)
		{
			this.protectedData = protectedData;
			this.publicData = publicData;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
