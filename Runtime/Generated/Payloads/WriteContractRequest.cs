using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class WriteContractRequest
	{
		public string func;
		public List<WriteContractRequestArgsInner> args;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public WriteContractRequest()
		{
		}

		public WriteContractRequest(string func, List<WriteContractRequestArgsInner> args)
		{
			this.func = func;
			this.args = args;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
