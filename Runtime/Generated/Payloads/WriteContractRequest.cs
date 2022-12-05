using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class WriteContractRequest
	{
		public string func;
		public List<WriteContractRequestArgsInner> args;

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
