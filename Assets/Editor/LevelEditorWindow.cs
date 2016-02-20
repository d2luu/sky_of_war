using UnityEditor;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelEditorWindow : EditorWindow
{
	/*
	public static LevelEditorWindow instance;
	
	public static string levelName = EditorPrefs.GetString("Level_Name");

	public GameObject backGround;

	public static void OpenWindow()
	{
		instance = (LevelEditorWindow)EditorWindow.GetWindow(typeof(LevelEditorWindow));
		instance.title = "Level Editor";
	}
	void OnGUI()
	{
		GUILayout.Label("Level Info", EditorStyles.boldLabel);
		levelName = EditorGUILayout.TextField("Name", levelName);

		EditorGUILayout.BeginHorizontal();
		if (GUILayout.Button("<"))
		{
			LevelEditor.LoadLevel(EditorPrefs.GetInt("Current_Level") - 1);
			levelName = EditorPrefs.GetString("Level_Name");
			Repaint();
		}

		if (GUILayout.Button(">"))
		{
			LevelEditor.LoadLevel(EditorPrefs.GetInt("Current_Level") + 1);
			levelName = EditorPrefs.GetString("Level_Name");
			Repaint();
		}
		if (GUILayout.Button("Save"))
		{
			LevelEditor.Save();
		}
		if (GUILayout.Button("Load"))
		{
			Load();
			Repaint();
		}
		
		EditorGUILayout.EndHorizontal();
	}
	private static void Load()
	{
		LevelEditor.LoadLevel();
		levelName = EditorPrefs.GetString("Level_Name");
	}
	private static void Load(int index)
	{
		LevelEditor.LoadLevel(index);
		levelName = EditorPrefs.GetString("Level_Name");
	}
*/
}





