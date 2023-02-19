using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class CreateCollectionItemRequest
	{
		public int id;
		public string name;
		public string description;
		public byte[] imageBase64;
		public string imageUrl;
		public string externalUrl;
		public List<CreateCollectionItemRequestAttributesInner> attributes;
		public Object data;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public CreateCollectionItemRequest()
		{
		}

		public CreateCollectionItemRequest(int id, string name, string description, byte[] imageBase64, string imageUrl, string externalUrl, List<CreateCollectionItemRequestAttributesInner> attributes, Object data)
		{
			this.id = id;
			this.name = name;
			this.description = description;
			this.imageBase64 = imageBase64;
			this.imageUrl = imageUrl;
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
