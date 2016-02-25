using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class AirFighterLoader {

	static string resourcePath = "Data/Fighter";
	//static string spritePath = "Graphic/Characteur/air fighter/";
	//static List<Sprite> sprites;


	public static List<Enemy> LoadAll()
	{
		List<Enemy> data = GetData();
		
		for (int i = 0; i < data.Count; i++)
		{
			Texture2D tex = (Texture2D)Resources.Load("Graphic/Characteur/air fighter/" + data[i].ID);
			data[i].sprite = Sprite.Create(tex, new Rect(0,0,tex.width, tex.height), new Vector2(0.5f, 0.5f));
			data[i].sprite.name = data[i].name;


		}
	
		return data;
	}

	static List<Enemy> GetData()
	{
		List<Enemy> data = new List<Enemy>();
		TextAsset file = Resources.Load(resourcePath) as TextAsset;
		XmlSerializer xml = new XmlSerializer(typeof(List<Enemy>));
		StringReader textData = new StringReader(file.text);
		data = xml.Deserialize(textData) as List<Enemy>;
		textData.Close();
		return data;
	}

}
