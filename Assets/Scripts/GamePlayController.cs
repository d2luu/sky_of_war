using UnityEngine;
using System.Collections;

public class GamePlayController : MonoBehaviour {
	//public GameObject BG_map;
	public float speedMap = 0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 offset = new Vector2 (0,Time.time * speedMap);
	}

}
