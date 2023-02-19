using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class EcosystemModel
	{
		public string id;
		public string email;
		public string name;
		public string iconImageUrl;
		public string coverImageUrl;
		public string primaryColorHex;
		public string publishedKey;
		public string secretKey;
		public string updatedAt;
		public string createdAt;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public EcosystemModel()
		{
		}

		public EcosystemModel(string id, string email, string name, string iconImageUrl, string coverImageUrl, string primaryColorHex, string publishedKey, string secretKey, string updatedAt, string createdAt)
		{
			this.id = id;
			this.email = email;
			this.name = name;
			this.iconImageUrl = iconImageUrl;
			this.coverImageUrl = coverImageUrl;
			this.primaryColorHex = primaryColorHex;
			this.publishedKey = publishedKey;
			this.secretKey = secretKey;
			this.updatedAt = updatedAt;
			this.createdAt = createdAt;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
