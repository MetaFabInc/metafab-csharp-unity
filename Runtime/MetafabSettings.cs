using System;
using System.IO;
using System.Linq;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace MetafabSdk
{
	public class MetafabSettings : ScriptableObject
	{
		[Tooltip("Published Key of your game https://docs.trymetafab.com/docs/first-steps-start-here")]
		public string PublishedKey;
		[Tooltip("Secret Key")]
		public string SecretKey;
		[Tooltip("Email")]
		public string Email;
		[Tooltip("Password")]
		public string Password;
		[Tooltip("Log Level")]
		public LogLevel LogLevel;
		[Tooltip("Wallet Decrypt Key")]
		public string WalletDecryptKey;

		#region static
		private static MetafabSettings _instance;

		public static void LoadSettings()
		{
			if (!_instance)
			{
				_instance = FindOrCreateInstance();
				Config.LogLevel = _instance.LogLevel;
				Config.Email = _instance.Email;
				Config.Password = _instance.Password;
				Config.WalletDecryptKey = _instance.WalletDecryptKey;
				Config.PublishedKey = _instance.PublishedKey;
			}
		}

		public static void ClearInstance()
		{
			_instance = null;
		}

		public static MetafabSettings Instance
		{
			get
			{
				LoadSettings();
				return _instance;
			}
		}

		private static MetafabSettings FindOrCreateInstance()
		{
			MetafabSettings instance = null;
			instance = instance ? null : Resources.Load<MetafabSettings>("Metafab");
			instance = instance ? instance : Resources.LoadAll<MetafabSettings>(string.Empty).FirstOrDefault();
			instance = instance ? instance : CreateAndSave<MetafabSettings>();
			if (instance == null) throw new Exception("Could not find or create settings for Metafab");
			return instance;
		}

		private static T CreateAndSave<T>() where T : ScriptableObject
		{
			T instance = CreateInstance<T>();
#if UNITY_EDITOR
			//Saving during Awake() will crash Unity, delay saving until next editor frame
			if (EditorApplication.isPlayingOrWillChangePlaymode)
			{
				EditorApplication.delayCall += () => SaveAsset(instance);
			}
			else
			{
				SaveAsset(instance);
			}
#endif
			return instance;
		}

#if UNITY_EDITOR
		private static void SaveAsset<T>(T obj) where T : ScriptableObject
		{

			string dirName = "Assets/Resources";
			if (!Directory.Exists(dirName))
			{
				Directory.CreateDirectory(dirName);
			}
			AssetDatabase.CreateAsset(obj, "Assets/Resources/Metafab.asset");
			AssetDatabase.SaveAssets();
		}
#endif
		#endregion
	}
}
