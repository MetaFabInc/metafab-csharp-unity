using System;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using Object = System.Object;

namespace MetafabSdk
{
	public class GamesApi
	{
		ApiClient apiClient;

		public GamesApi(ApiClient apiClient) {
			this.apiClient = apiClient;
		}


		/// <summary>
		/// Authenticate game
		/// </summary>
		///
		/// <remarks>
		/// Returns an existing game object containing authorization keys and credentials when provided a valid email (in place of username) and password login using Basic Auth.
		/// </remarks>
		/// <returns>AuthGame200Response</returns>
		public async UniTask<AuthGame200Response> AuthGame(string email, string password, CancellationToken token = default)
		{
			apiClient.BasicAuth = $"{email}:{password}";
			return await apiClient.Get<AuthGame200Response>($"/v1/games/auth?sdk=unity");

		}

		/// <summary>
		/// Create game
		/// </summary>
		///
		/// <remarks>
		/// Create a new game. A game is the root entity required for all API interactions. Contracts, currencies, items and more are deployed by games, player accounts are created and registered to games, etc.  To use any of MetaFab's services, you must first create a game through this endpoint.  After creating your game through this endpoint, a verification email will be sent to the email address used. Before you can access any of MetaFab's features, you'll need to click the link contained in the verification email to verify your account.
		/// </remarks>
		/// <returns>AuthGame200Response</returns>
		public async UniTask<AuthGame200Response> CreateGame(CreateGameRequest createGameRequest, CancellationToken token = default)
		{
			
			return await apiClient.Post<AuthGame200Response>($"/v1/games?sdk=unity", createGameRequest);

		}

		/// <summary>
		/// Get game
		/// </summary>
		///
		/// <remarks>
		/// Returns a game object for the provided game id.
		/// </remarks>
		/// <returns>PublicGame</returns>
		public async UniTask<PublicGame> GetGame(string gameId, CancellationToken token = default)
		{
			
			return await apiClient.Get<PublicGame>($"/v1/games/{gameId}?sdk=unity");

		}

		/// <summary>
		/// Update game
		/// </summary>
		///
		/// <remarks>
		/// Update various fields specific to a game. Such as changing its password, resetting its published or secret key, or updating its RPCs.
		/// </remarks>
		/// <returns>GameModel</returns>
		public async UniTask<GameModel> UpdateGame(string gameId, UpdateGameRequest updateGameRequest, CancellationToken token = default)
		{
			
			return await apiClient.Patch<GameModel>($"/v1/games/{gameId}?sdk=unity", updateGameRequest);

		}
	}
}
