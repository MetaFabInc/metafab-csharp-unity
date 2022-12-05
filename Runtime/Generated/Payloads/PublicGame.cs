using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class PublicGame
	{
		public string id;
		public string name;
		public string publishedKey;
		public string updatedAt;
		public string createdAt;

		public PublicGame(string id, string name, string publishedKey, string updatedAt, string createdAt)
		{
			this.id = id;
			this.name = name;
			this.publishedKey = publishedKey;
			this.updatedAt = updatedAt;
			this.createdAt = createdAt;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
