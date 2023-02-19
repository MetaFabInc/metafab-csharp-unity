using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class PublicGame
	{
		public string id;
		public string name;
		public string publishedKey;
		public List<string> redirectUris;
		public string iconImageUrl;
		public string coverImageUrl;
		public string primaryColorHex;
		public string updatedAt;
		public string createdAt;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public PublicGame()
		{
		}

		public PublicGame(string id, string name, string publishedKey, List<string> redirectUris, string iconImageUrl, string coverImageUrl, string primaryColorHex, string updatedAt, string createdAt)
		{
			this.id = id;
			this.name = name;
			this.publishedKey = publishedKey;
			this.redirectUris = redirectUris;
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
