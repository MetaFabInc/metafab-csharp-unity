using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class CreateWalletSignature200Response
	{
		public string signature;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public CreateWalletSignature200Response()
		{
		}

		public CreateWalletSignature200Response(string signature)
		{
			this.signature = signature;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
