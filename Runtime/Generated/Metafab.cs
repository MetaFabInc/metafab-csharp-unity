using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

namespace MetafabSdk
{
	public static class Metafab
	{
		
		public static ContractsApi ContractsApi;
		public static CurrenciesApi CurrenciesApi;
		public static GamesApi GamesApi;
		public static ItemsApi ItemsApi;
		public static LootboxesApi LootboxesApi;
		public static PlayersApi PlayersApi;
		public static ShopsApi ShopsApi;
		public static TransactionsApi TransactionsApi;
		public static WalletsApi WalletsApi;

		static ApiClient apiClient;
		static string baseUrl = "https://api.trymetafab.com";

		public static string PublishedKey {
			get => apiClient.headers.ContainsKey("X-Game-Key") ? apiClient.headers["X-Game-Key"] : null;
			set => apiClient.headers["X-Game-Key"] = value;
		}

		public static string SecretKey {
			get => apiClient.headers.ContainsKey("X-Authorization") ? apiClient.headers["X-Authorization"] : null;
			set => apiClient.headers["X-Authorization"] = value;
		}

		public static string Password {
			get => apiClient.headers.ContainsKey("X-Password") ? apiClient.headers["X-Password"] : null;
			set => apiClient.headers["X-Password"] = value;
		}

		static Metafab()
		{
			apiClient = new ApiClient(baseUrl);

			
			ContractsApi = new ContractsApi(apiClient);
			CurrenciesApi = new CurrenciesApi(apiClient);
			GamesApi = new GamesApi(apiClient);
			ItemsApi = new ItemsApi(apiClient);
			LootboxesApi = new LootboxesApi(apiClient);
			PlayersApi = new PlayersApi(apiClient);
			ShopsApi = new ShopsApi(apiClient);
			TransactionsApi = new TransactionsApi(apiClient);
			WalletsApi = new WalletsApi(apiClient);
		}

		// Don't log in build unless users opt in
		[Conditional("UNITY_EDITOR"), Conditional("METAFAB_LOGGING")]
		static void Log(LogLevel level, string msg)
		{
			if (Config.LogLevel == LogLevel.None || Config.LogLevel < level) { return; }
			switch (Config.LogLevel)
			{
				case LogLevel.Warning:
					Debug.LogWarning($"Metafab | {Time.frameCount} | {msg}");
					break;
				case LogLevel.Error:
					Debug.LogError($"Metafab | {Time.frameCount} | {msg}");
					break;
				default:
					Debug.Log($"Metafab | {Time.frameCount} | {msg}");
					break;
			}
		}
	}
}