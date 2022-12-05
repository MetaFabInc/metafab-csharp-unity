using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class SetCollectionItemTimelockRequest
	{
		public int timelock;

		public SetCollectionItemTimelockRequest(int timelock)
		{
			this.timelock = timelock;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
