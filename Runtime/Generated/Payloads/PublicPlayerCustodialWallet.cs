using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class PublicPlayerCustodialWallet
	{
		public string id;
		public string address;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public PublicPlayerCustodialWallet()
		{
		}

		public PublicPlayerCustodialWallet(string id, string address)
		{
			this.id = id;
			this.address = address;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
