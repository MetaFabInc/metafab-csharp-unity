using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class UpdateGame200ResponseAllOf
	{
		public string walletDecryptKey;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public UpdateGame200ResponseAllOf()
		{
		}

		public UpdateGame200ResponseAllOf(string walletDecryptKey)
		{
			this.walletDecryptKey = walletDecryptKey;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
