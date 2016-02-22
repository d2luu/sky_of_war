using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {
	int hp = 120;
	// Use this for initialization
	public static Wall init(Vector2 position){
		GameObject wallObj= Boss.NewObjectFromPrefab("wall",position);
		return wallObj.AddComponent <Wall>() as Wall;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
