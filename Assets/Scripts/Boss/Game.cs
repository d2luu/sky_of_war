using UnityEngine;
using System.Collections;
using UnityEditor;

public class Game : MonoBehaviour {
	// Use this for initialization
	Boss boss;
	GameObject bossObj;
	void Start () {
		Object prefab = AssetDatabase.LoadAssetAtPath("Assets/Prefabs/boss_boat.prefab", typeof(GameObject));
		bossObj = Instantiate(prefab, Vector2.zero, Quaternion.identity) as GameObject;
		// Modify the clone to your heart's content
//		clone.transform.position = Vector3.one;

	}
	public void move(){
		bossObj.GetComponent<Rigidbody2D>().velocity = transform.right.normalized * 2;
	}
	void Update () {	
		move ();
	}
}
