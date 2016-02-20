using UnityEngine;
using System.Collections;

public class PlayerDemo : MonoBehaviour {

	public float speed;
	public Transform cameraTrans;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < cameraTrans.position.x-1) {
			cameraTrans.position+=new Vector3(-0.01f,0,0);
			if(cameraTrans.position.x==transform.position.x-1)
			{
				return;
			}
		}

		if (Input.GetKey (KeyCode.A)) {
			transform.position+=new Vector3(-speed,0,0);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.position+=new Vector3(speed,0,0);
		}
	}
}
