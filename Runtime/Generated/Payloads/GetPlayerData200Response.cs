using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class GetPlayerData200Response
	{
		public Object protectedData;
		public Object publicData;

		public GetPlayerData200Response(Object protectedData, Object publicData)
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
