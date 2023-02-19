using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class WriteContractRequestArgsInner
	{


		public WriteContractRequestArgsInner()
		{
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
