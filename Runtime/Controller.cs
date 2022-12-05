using UnityEngine;

namespace MetafabSdk
{
	internal class Controller : MonoBehaviour
	{
		#region Singleton

		private static Controller _instance;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void InitializeBeforeSceneLoad()
		{
			MetafabSettings.ClearInstance();
			MetafabSettings.LoadSettings();
			Initialize();
		}

		internal static void Initialize()
		{
			GetInstance();
		}

		internal static Controller GetInstance()
		{
			if (_instance == null)
			{
				GameObject g = new GameObject("Metafab");
				_instance = g.AddComponent<Controller>();
				DontDestroyOnLoad(g);
			}
			return _instance;
		}

		#endregion
	}
}