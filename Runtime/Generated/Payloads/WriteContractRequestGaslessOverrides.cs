using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class WriteContractRequestGaslessOverrides
	{
		public Object forwardRequest;
		public Object domain;
		public Object types;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public WriteContractRequestGaslessOverrides()
		{
		}

		public WriteContractRequestGaslessOverrides(Object forwardRequest, Object domain, Object types)
		{
			this.forwardRequest = forwardRequest;
			this.domain = domain;
			this.types = types;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
