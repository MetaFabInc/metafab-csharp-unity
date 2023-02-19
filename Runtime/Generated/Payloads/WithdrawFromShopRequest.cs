using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class WithdrawFromShopRequest
	{
		public string address;
		public string walletId;
		public string currencyAddress;
		public string currencyId;
		public string collectionAddress;
		public string collectionId;
		public List<int> itemIds;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public WithdrawFromShopRequest()
		{
		}

		public WithdrawFromShopRequest(string address, string walletId, string currencyAddress, string currencyId, string collectionAddress, string collectionId, List<int> itemIds)
		{
			this.address = address;
			this.walletId = walletId;
			this.currencyAddress = currencyAddress;
			this.currencyId = currencyId;
			this.collectionAddress = collectionAddress;
			this.collectionId = collectionId;
			this.itemIds = itemIds;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
