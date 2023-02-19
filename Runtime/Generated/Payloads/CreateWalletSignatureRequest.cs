using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class CreateWalletSignatureRequest
	{
		public string message;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public CreateWalletSignatureRequest()
		{
		}

		public CreateWalletSignatureRequest(string message)
		{
			this.message = message;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
