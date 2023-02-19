using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class SetPlayerDataRequest
	{
		public Object protectedData;
		public Object publicData;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public SetPlayerDataRequest()
		{
		}

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
