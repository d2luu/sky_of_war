using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Collections.Generic;


public class LevelEditorWindow : EditorWindow {
	
	public static LevelEditorWindow instance;

	public static string levelName = EditorPrefs.GetString(EditorAttributes.LEVEL_NAME);
	public static int difficult = EditorPrefs.GetInt(EditorAttributes.LEVEL_DIFFICULT);

	public static void OpenWindow()
	{
		instance = (LevelEditorWindow)EditorWindow.GetWindow(typeof(LevelEditorWindow));
		
		//instance.title = "Map Editor";
	}

	void OnGUI()
	{
		GUILayout.Label ("Map Info", EditorStyles.boldLabel);
		levelName = EditorGUILayout.TextField ("Name", levelName);
		difficult = EditorGUILayout.IntField ("Difficult", difficult);

		EditorGUILayout.Separator ();
		EditorGUILayout.BeginHorizontal ();
		if (GUILayout.Button ("Clear")) {
			LevelEditor.ClearAll ();
		}
		EditorGUILayout.EndHorizontal ();

		EditorGUILayout.BeginHorizontal ();
		if (GUILayout.Button ("<")) {
			
			LevelEditor.LoadLevel (EditorPrefs.GetInt ("Current_Level") - 1);
			levelName = EditorPrefs.GetString ("Level_Name");
			difficult = EditorPrefs.GetInt ("Level_Difficult");
			Repaint ();
		}
		if (GUILayout.Button (">")) {
			LevelEditor.LoadLevel (EditorPrefs.GetInt ("Current_Level") - 1);
			levelName = EditorPrefs.GetString ("Level_Name");
			difficult = EditorPrefs.GetInt ("Level_Difficult");
			Repaint ();
		}
		if (GUILayout.Button ("Save")) {
			LevelEditor.Save ();
		}
		if (GUILayout.Button ("Load")) {
			Load ();
			Repaint ();
		}
		
		
		EditorGUILayout.EndHorizontal ();
	}

		public static void Load()
		{
			LevelEditor.LoadLevel();
			levelName = EditorPrefs.GetString("Level_Name");
			difficult = EditorPrefs.GetInt("Level_Difficult");
		}
		private static void Load(int index)
		{
			LevelEditor.LoadLevel(index);
			levelName = EditorPrefs.GetString("Level_Name");
			difficult = EditorPrefs.GetInt("Level_Difficult");
		}

}
