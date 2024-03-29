using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class BatchTransferCurrencyRequest
	{
		public List<string> addresses;
		public List<string> walletIds;
		public List<float> amounts;
		public List<float> references;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public BatchTransferCurrencyRequest()
		{
		}

		public BatchTransferCurrencyRequest(List<string> addresses, List<string> walletIds, List<float> amounts, List<float> references)
		{
			this.addresses = addresses;
			this.walletIds = walletIds;
			this.amounts = amounts;
			this.references = references;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
