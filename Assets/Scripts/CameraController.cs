using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform playerTrans;
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector3 (playerTrans.position.x, playerTrans.position.y + 0.12f, -10);
	}
}
