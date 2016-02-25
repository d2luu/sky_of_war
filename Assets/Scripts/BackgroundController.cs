using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour {
	public float speed;
	bool isMove;
	// Use this for initialization
	void Start () {
		isMove = true;
	}
	
	// Update is called once per frame
	void Update () {

		if (isMove) {
			transform.position += new Vector3 (0, -speed, 0);
			if (transform.position.y <= -32.0f) {
				isMove = false;
			}
		}
	}
}
