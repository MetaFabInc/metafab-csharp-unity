using System;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using Object = System.Object;

namespace MetafabSdk
{
	public partial class EcosystemsApi
	{
		ApiClient apiClient;

		public EcosystemsApi(ApiClient apiClient) {
			this.apiClient = apiClient;
		}


		/// <summary>
		/// Approve ecosystem game
		/// </summary>
		///
		/// <remarks>
		/// Approves a game for an ecosystem. By approving a game, it allows that game to integrate the ability for profile accounts from an ecosystem to login directly to the approved game and play. This also allows games to request access to assets held at the profile level for the game to frictionlessly interact with on behalf of the profile.
		/// </remarks>
		/// <returns>HttpResponse</returns>
		public async UniTask<HttpResponse> ApproveEcosystemGame(string ecosystemId, ApproveEcosystemGameRequest approveEcosystemGameRequest, CancellationToken token = default, Dictionary<string, string> headers = null)
		{
			
			return await apiClient.Post<HttpResponse>($"/v1/ecosystems/{ecosystemId}/games?sdk=unity", approveEcosystemGameRequest, headers: headers);

		}

		/// <summary>
		/// Authenticate ecosystem
		/// </summary>
		///
		/// <remarks>
		/// Returns an existing ecosystem object containing authorization keys when provided a valid email (in place of username) and password login using Basic Auth.
		/// </remarks>
		/// <returns>EcosystemModel</returns>
		public async UniTask<EcosystemModel> AuthEcosystem(string email, string password, CancellationToken token = default, Dictionary<string, string> headers = null)
		{
			apiClient.BasicAuth = $"{email}:{password}";
			return await apiClient.Get<EcosystemModel>($"/v1/ecosystems/auth?sdk=unity", headers: headers);

		}

		/// <summary>
		/// Authenticate profile
		/// </summary>
		///
		/// <remarks>
		/// Returns an existing profile object containing access token, wallet, and other details when provided a valid profile username and password login using Basic Auth.
		/// </remarks>
		/// <returns>AuthProfile200Response</returns>
		public async UniTask<AuthProfile200Response> AuthProfile(string email, string password, CancellationToken token = default, Dictionary<string, string> headers = null)
		{
			apiClient.BasicAuth = $"{email}:{password}";
			return await apiClient.Get<AuthProfile200Response>($"/v1/profiles/auth?sdk=unity", headers: headers);

		}

		/// <summary>
		/// Authenticate profile player
		/// </summary>
		///
		/// <remarks>
		/// Returns an existing player object containing access token, wallet, wallet decrypt key, profile authorization and other details for a game when provided profile authentication and the player's username.
		/// </remarks>
		/// <returns>AuthPlayer200Response</returns>
		public async UniTask<AuthPlayer200Response> AuthProfilePlayer(string profileId, string gameId, CancellationToken token = default, Dictionary<string, string> headers = null)
		{
			
			return await apiClient.Get<AuthPlayer200Response>($"/v1/profiles/{profileId}/games/{gameId}/players/auth?sdk=unity", headers: headers);

		}

		/// <summary>
		/// Create ecosystem
		/// </summary>
		///
		/// <remarks>
		/// Create a new ecosystem. An ecosystem is a parent entity that many profiles live under for a given ecosystem of games. Ecosystems allow your players to create one profile within your ecosystem that allows a single account and wallet to be used across all of the approved games in your ecosystem that they play.
		/// </remarks>
		/// <returns>EcosystemModel</returns>
		public async UniTask<EcosystemModel> CreateEcosystem(CreateEcosystemRequest createEcosystemRequest, CancellationToken token = default, Dictionary<string, string> headers = null)
		{
			
			return await apiClient.Post<EcosystemModel>($"/v1/ecosystems?sdk=unity", createEcosystemRequest, headers: headers);

		}

		/// <summary>
		/// Create profile
		/// </summary>
		///
		/// <remarks>
		/// Create a new profile. Profiles are automatically associated with an internally managed wallet. Profiles can be thought of as a umbrella account that can be used to sign into and create player accounts across many games and have a singular asset store wallet at the profile level that can be used across all connected player accounts for games those player accounts are a part of.  Profiles are associated to a parent ecosystem of games. This allows an ecosystem to approve a permissioned set of games that can request authorized wallet permissions from profiles of players for their game.
		/// </remarks>
		/// <returns>AuthProfile200Response</returns>
		public async UniTask<AuthProfile200Response> CreateProfile(CreateProfileRequest createProfileRequest, CancellationToken token = default, Dictionary<string, string> headers = null)
		{
			
			return await apiClient.Post<AuthProfile200Response>($"/v1/profiles?sdk=unity", createProfileRequest, headers: headers);

		}

		/// <summary>
		/// Create profile player
		/// </summary>
		///
		/// <remarks>
		/// Creates a new player account for the provided game id linked to the authenticating profile. The created player account will default to using the parent profile's wallet for any transactions, wallet content balance checks and verifications, and more.
		/// </remarks>
		/// <returns>AuthPlayer200Response</returns>
		public async UniTask<AuthPlayer200Response> CreateProfilePlayer(string profileId, string gameId, CreateProfilePlayerRequest createProfilePlayerRequest, CancellationToken token = default, Dictionary<string, string> headers = null)
		{
			
			return await apiClient.Post<AuthPlayer200Response>($"/v1/profiles/{profileId}/games/{gameId}/players?sdk=unity", createProfilePlayerRequest, headers: headers);

		}

		/// <summary>
		/// Get ecosystem
		/// </summary>
		///
		/// <remarks>
		/// Returns a ecosystem object for the provided ecosystem id.
		/// </remarks>
		/// <returns>PublicEcosystem</returns>
		public async UniTask<PublicEcosystem> GetEcosystem(string ecosystemId, CancellationToken token = default, Dictionary<string, string> headers = null)
		{
			
			return await apiClient.Get<PublicEcosystem>($"/v1/ecosystems/{ecosystemId}?sdk=unity", headers: headers);

		}

		/// <summary>
		/// Get ecosystem game
		/// </summary>
		///
		/// <remarks>
		/// Returns a game object for the provided game id that the ecosystem has approved.
		/// </remarks>
		/// <returns>PublicGame</returns>
		public async UniTask<PublicGame> GetEcosystemGame(string ecosystemId, string gameId, CancellationToken token = default, Dictionary<string, string> headers = null)
		{
			
			return await apiClient.Get<PublicGame>($"/v1/ecosystems/{ecosystemId}/games/{gameId}?sdk=unity", headers: headers);

		}

		/// <summary>
		/// Get ecosystem games
		/// </summary>
		///
		/// <remarks>
		/// Returns an array of games the ecosystem has approved.
		/// </remarks>
		/// <returns>List<PublicGame></returns>
		public async UniTask<List<PublicGame>> GetEcosystemGames(string ecosystemId, CancellationToken token = default, Dictionary<string, string> headers = null)
		{
			
			return await apiClient.Get<List<PublicGame>>($"/v1/ecosystems/{ecosystemId}/games?sdk=unity", headers: headers);

		}

		/// <summary>
		/// Get profile game
		/// </summary>
		///
		/// <remarks>
		/// Returns a game this profile has connected player accounts for.
		/// </remarks>
		/// <returns>GetProfileGames200ResponseInner</returns>
		public async UniTask<GetProfileGames200ResponseInner> GetProfileGame(string profileId, string gameId, CancellationToken token = default, Dictionary<string, string> headers = null)
		{
			
			return await apiClient.Get<GetProfileGames200ResponseInner>($"/v1/profiles/{profileId}/games/{gameId}?sdk=unity", headers: headers);

		}

		/// <summary>
		/// Get profile games
		/// </summary>
		///
		/// <remarks>
		/// Returns an array of games the authorized profile has connected player accounts for.
		/// </remarks>
		/// <returns>List<GetProfileGames200ResponseInner></returns>
		public async UniTask<List<GetProfileGames200ResponseInner>> GetProfileGames(string profileId, CancellationToken token = default, Dictionary<string, string> headers = null)
		{
			
			return await apiClient.Get<List<GetProfileGames200ResponseInner>>($"/v1/profiles/{profileId}/games?sdk=unity", headers: headers);

		}

		/// <summary>
		/// Unapprove ecosystem game
		/// </summary>
		///
		/// <remarks>
		/// Unapproves a game for an ecosystem. The game will no longer be able to allow profiles from the ecosystem to login. All profile permissions approved for the game will also be revoked.
		/// </remarks>
		/// <returns>HttpResponse</returns>
		public async UniTask<HttpResponse> UnapproveEcosystemGame(string ecosystemId, string gameId, CancellationToken token = default, Dictionary<string, string> headers = null)
		{
			
			return await apiClient.Delete<HttpResponse>($"/v1/ecosystems/{ecosystemId}/games/{gameId}?sdk=unity", headers: headers);

		}

		/// <summary>
		/// Update ecosystem
		/// </summary>
		///
		/// <remarks>
		/// Update various fields specific to an ecosystem. Such as changing its password, resetting its published or secret key, or updating its approved games.
		/// </remarks>
		/// <returns>EcosystemModel</returns>
		public async UniTask<EcosystemModel> UpdateEcosystem(string ecosystemId, UpdateEcosystemRequest updateEcosystemRequest, CancellationToken token = default, Dictionary<string, string> headers = null)
		{
			
			return await apiClient.Patch<EcosystemModel>($"/v1/ecosystems/{ecosystemId}?sdk=unity", updateEcosystemRequest, headers: headers);

		}

		/// <summary>
		/// Update profile
		/// </summary>
		///
		/// <remarks>
		/// Update various fields specific to a profile. Such as changing its password and resetting its access token.
		/// </remarks>
		/// <returns>ProfileModel</returns>
		public async UniTask<ProfileModel> UpdateProfile(string profileId, UpdateProfileRequest updateProfileRequest, CancellationToken token = default, Dictionary<string, string> headers = null)
		{
			
			return await apiClient.Patch<ProfileModel>($"/v1/profiles/{profileId}?sdk=unity", updateProfileRequest, headers: headers);

		}

		/// <summary>
		/// Update profile player
		/// </summary>
		///
		/// <remarks>
		/// Update various fields specific to a player. Such as changing its permissions.
		/// </remarks>
		/// <returns>UpdateProfilePlayer200Response</returns>
		public async UniTask<UpdateProfilePlayer200Response> UpdateProfilePlayer(string profileId, string gameId, string playerId, UpdateProfilePlayerRequest updateProfilePlayerRequest, CancellationToken token = default, Dictionary<string, string> headers = null)
		{
			
			return await apiClient.Patch<UpdateProfilePlayer200Response>($"/v1/profiles/{profileId}/games/{gameId}/players/{playerId}?sdk=unity", updateProfilePlayerRequest, headers: headers);

		}
	}
}
