using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class CollectionItem
	{
		public string id;
		public string image;
		public string name;
		public string description;
		public string externalUrl;
		public List<CollectionItemAttributesInner> attributes;
		public Object data;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public CollectionItem()
		{
		}

		public CollectionItem(string id, string image, string name, string description, string externalUrl, List<CollectionItemAttributesInner> attributes, Object data)
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
