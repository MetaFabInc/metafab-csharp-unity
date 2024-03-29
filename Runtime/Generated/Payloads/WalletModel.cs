using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class WalletModel
	{
		public string id;
		public string address;
		public Object backupCiphertexts;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public WalletModel()
		{
		}

		public WalletModel(string id, string address, Object backupCiphertexts)
		{
			this.id = id;
			this.address = address;
			this.backupCiphertexts = backupCiphertexts;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
