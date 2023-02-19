using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class GetProfileGames200ResponseInner
	{
		public string id;
		public string name;
		public string publishedKey;
		public string iconImageUrl;
		public string coverImageUrl;
		public string primaryColorHex;
		public string createdAt;
		public List<PublicPlayer> players;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public GetProfileGames200ResponseInner()
		{
		}

		public GetProfileGames200ResponseInner(string id, string name, string publishedKey, string iconImageUrl, string coverImageUrl, string primaryColorHex, string createdAt, List<PublicPlayer> players)
		{
			this.id = id;
			this.name = name;
			this.publishedKey = publishedKey;
			this.iconImageUrl = iconImageUrl;
			this.coverImageUrl = coverImageUrl;
			this.primaryColorHex = primaryColorHex;
			this.createdAt = createdAt;
			this.players = players;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
