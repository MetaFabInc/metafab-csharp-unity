using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class PublicEcosystem
	{
		public string id;
		public string name;
		public string publishedKey;
		public string iconImageUrl;
		public string coverImageUrl;
		public string primaryColorHex;
		public string updatedAt;
		public string createdAt;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public PublicEcosystem()
		{
		}

		public PublicEcosystem(string id, string name, string publishedKey, string iconImageUrl, string coverImageUrl, string primaryColorHex, string updatedAt, string createdAt)
		{
			this.id = id;
			this.name = name;
			this.publishedKey = publishedKey;
			this.iconImageUrl = iconImageUrl;
			this.coverImageUrl = coverImageUrl;
			this.primaryColorHex = primaryColorHex;
			this.updatedAt = updatedAt;
			this.createdAt = createdAt;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
