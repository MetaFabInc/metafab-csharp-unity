using System.Collections.Generic;

namespace MetafabSdk {
	public struct HttpResponse {
		public ushort status;
		public string body;
		public bool IsSuccess => 200 <= status && status <= 299;
		public Dictionary<string, string> headers;
	}
}
