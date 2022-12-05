using UnityEditor;

#if UNITY_2018_3_OR_NEWER
namespace MetafabSdk.Editor
{
    internal class MetafabSettingsEditor
    {
        [SettingsProvider]
        internal static SettingsProvider CreateCustomSettingsProvider()
        {
            // First parameter is the path in the Settings window.
            // Second parameter is the scope of this setting: it only appears in the Project Settings window.
            var provider = new SettingsProvider("Project/Metafab", SettingsScope.Project)
            {
                // Create the SettingsProvider and initialize its drawing (IMGUI) function in place:
                guiHandler = (searchContext) =>
                {
                    UnityEditor.Editor.CreateEditor(MetafabSettings.Instance).OnInspectorGUI();
                },

                // Populate the search keywords to enable smart search filtering and label highlighting:
                keywords = SettingsProvider.GetSearchKeywordsFromSerializedObject(new SerializedObject(MetafabSettings.Instance))
            };

            return provider;
        }
    }
}
#endif