using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

public class LevelEditor : Editor
{
	/*public static GameObject background = GameObject.Find("Background");
	public static string levelPath = Path.Combine(Path.Combine(Application.dataPath, "Resource"), "Level");
	public static string mapFile;

	[MenuItem("Tools/Level Editor/Level Editor %#L")]
	static void ShowEditorWindow()
	{
		LevelEditorWindow.OpenWindow();
	}
	[MenuItem("Tools/Level Editor/Load")]
	public static void LoadLevel()
	{
		//ClearAll();
		mapFile = EditorUtility.OpenFilePanel("Open XML File", levelPath, "xml");
		LevelEditorWindow.levelName = mapFile.Substring(0, mapFile.LastIndexOf(".xml"));
		EditorPrefs.SetString(EditorAttributes.LEVEL_NAME, mapFile.Substring(0, mapFile.LastIndexOf(".xml")));

		TextAsset levelFile = Resources.Load("Level/" + LevelEditorWindow.levelName) as TextAsset;
		StringReader file = new StringReader(levelFile.text);
		XmlSerializer level = new XmlSerializer(typeof(LevelData));
		LevelData data = level.Deserialize(file) as LevelData;
		file.Close();
	}
*/
}
