using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public class CollectionItem
	{
		public string id;
		public string image;
		public string name;
		public string description;
		public string externalUrl;
		public List<Object> attributes;
		public Object data;

		public CollectionItem(string id, string image, string name, string description, string externalUrl, List<Object> attributes, Object data)
		{
			this.id = id;
			this.image = image;
			this.name = name;
			this.description = description;
			this.externalUrl = externalUrl;
			this.attributes = attributes;
			this.data = data;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
