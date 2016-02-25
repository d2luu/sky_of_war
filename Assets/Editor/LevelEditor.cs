using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

public class LevelEditor : Editor{

	public static GameObject backGround = GameObject.Find("BackGround");
	public static GameObject player = GameObject.Find("Player");
	public static GameObject enemy = GameObject.Find("Enemy");
	public static GameObject boss = GameObject.Find("Boss");

	public static string levelPath = Path.Combine(Path.Combine(Application.dataPath, "Resources"), "Level");

	public static string mapFile;
	
	[MenuItem("MapEditor/Editor %#E")]
	static void ShowEditorWindow()
	{
		LevelEditorWindow.OpenWindow();
	}

	public static void ClearAll()
	{
		List<GameObject> objs = new List<GameObject>();
		if(backGround && player && enemy && boss)
		{
			for(int i =0; i< backGround.transform.childCount;i++)
			{
				objs.Add(backGround.transform.GetChild(i).gameObject);
			}
			for (int i = 0; i < player.transform.childCount; i++)
			{
				objs.Add(player.transform.GetChild(i).gameObject);
			}
			for (int i = 0; i < enemy.transform.childCount; i++)
			{
				objs.Add(enemy.transform.GetChild(i).gameObject);
			}
			for (int i = 0; i < boss.transform.childCount; i++)
			{
				objs.Add(boss.transform.GetChild(i).gameObject);
			}
		}
		
		foreach (GameObject obj in objs)
			DestroyImmediate(obj);
	}

	public static void Save()
	{
		StoreLevelData ();
	}

	public static void Load()
	{
		
	}

	public static void LoadLevel()
	{
		ClearAll ();
		
		mapFile = EditorUtility.OpenFilePanel ("Open XML File", levelPath, "xml");
		
		if (mapFile.Length > 0)
		if (mapFile.Length > 0) {
			mapFile = mapFile.Substring (mapFile.LastIndexOf ("/") + 1);
			LevelEditorWindow.levelName = mapFile.Substring (0, mapFile.LastIndexOf (".xml"));
			EditorPrefs.SetString (EditorAttributes.LEVEL_NAME, mapFile.Substring (0, mapFile.LastIndexOf (".xml")));

			TextAsset levelFile = Resources.Load ("Level/" + LevelEditorWindow.levelName) as TextAsset;
			Debug.Log (LevelEditorWindow.levelName);

			Debug.Log(levelFile);
			
			StringReader file = new StringReader (levelFile.text);
			XmlSerializer level = new XmlSerializer (typeof(LevelData));
			LevelData data = level.Deserialize (file) as LevelData;
			file.Close ();

			EditorPrefs.SetInt (EditorAttributes.LEVEL_DIFFICULT, data.Difficult);

			ObjectData[] backgrounds = data.Backgrounds;
			if (!backGround)
				backGround = GameObject.Find ("Background");
			for (int i = 0; i<backgrounds.Length; i++) {
				string path = "Background/" + backgrounds [i].name;
				Debug.Log(path);
				GameObject obj = (GameObject)PrefabUtility.InstantiatePrefab (Resources.Load (path));
				Debug.Log(obj);
				obj.transform.SetParent (backGround.transform);
				obj.transform.position = new Vector3 (data.Backgrounds [i].posX, data.Backgrounds [i].posY, data.Backgrounds [i].posZ);
				
			}
			ObjectData[] players = data.Player;
			if (!player)
				player = GameObject.Find ("Player");
			for (int i = 0; i<players.Length; i++) {
				string path = "Player/" + players [i].name;
				Debug.Log(path);
				GameObject obj = (GameObject)PrefabUtility.InstantiatePrefab (Resources.Load (path));
				Debug.Log(obj);
				obj.transform.SetParent (player.transform);
				obj.transform.position = new Vector3 (data.Player [i].posX, data.Player [i].posY, data.Player [i].posZ);
				
			}
		}
	}
	public static void LoadLevel(int index)
	{
		
	}

	public static void StoreLevelData()
	{
		if (backGround == null)
			backGround = GameObject.Find ("Background");
		if (player == null)
			player = GameObject.Find ("Player");
		if (enemy == null)
			enemy = GameObject.Find ("Enemy");
		if (boss == null)
			boss = GameObject.Find ("Boss");

		LevelData data = new LevelData ();
		data.Difficult = LevelEditorWindow.difficult;
		data.Name = LevelEditorWindow.levelName;
		EditorPrefs.SetString (EditorAttributes.LEVEL_NAME, data.Name);
		EditorPrefs.SetInt (EditorAttributes.LEVEL_DIFFICULT, data.Difficult);

		data.Backgrounds = new ObjectData[backGround.transform.childCount];
		data.Player = new ObjectData[player.transform.childCount]; //  num of child obj
		data.Enemy = new ObjectData[enemy.transform.childCount];
		data.Boss = new ObjectData[boss.transform.childCount];
		for (int i = 0; i < backGround.transform.childCount; i++) {
			//
			data.Backgrounds [i] = GetObjectData (backGround.transform.GetChild (i).gameObject);
			data.Backgrounds [i].posX = backGround.transform.GetChild (i).gameObject.transform.position.x;
			data.Backgrounds [i].posY = backGround.transform.GetChild (i).gameObject.transform.position.y;
			data.Backgrounds [i].posZ = backGround.transform.GetChild (i).gameObject.transform.position.z;
			
		}
		XmlSerializer level = new XmlSerializer (typeof(LevelData));
		FileStream fs = new FileStream (Path.Combine (levelPath, LevelEditorWindow.levelName + ".xml"), FileMode.Create);
		level.Serialize (fs, data);
		AssetDatabase.Refresh ();
		fs.Close ();
	}
	static ObjectData GetObjectData(GameObject obj)
	{
		ObjectData objectData = new ObjectData();
		
		objectData.name = GetPrefabName(obj);
		
		return objectData;
	}
	static string GetPrefabName(string path)
	{
		Debug.Log(path);
		path = path.Substring(path.LastIndexOf("/") + 1);
		Debug.Log(path);
		path = path.Substring(0, path.LastIndexOf(".prefab"));
		Debug.Log(path);
		return path;
	}
	static string GetPrefabName(GameObject o)
	{
		return GetPrefabName(GetPrefabAssetPath(o));
	}
	static string GetPrefabAssetPath(GameObject go)
	{
		return AssetDatabase.GetAssetPath(PrefabUtility.GetPrefabParent(go));
		
	}

}
