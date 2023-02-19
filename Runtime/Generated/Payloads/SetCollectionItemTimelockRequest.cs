using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class SetCollectionItemTimelockRequest
	{
		public int timelock;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public SetCollectionItemTimelockRequest()
		{
		}

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
