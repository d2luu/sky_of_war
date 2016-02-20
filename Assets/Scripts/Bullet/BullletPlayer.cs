using UnityEngine;
using System.Collections;

public class BullletPlayer : Bullet {
	public Animation anim;
	// Use this for initialization
	void Start () {
		//move bullet up
		GetComponent<Rigidbody2D> ().velocity = transform.up * speed;
	}
	void Update(){
		Destroy (gameObject,bullet_time_remove);
	}
	// xu lý va cham
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.CompareTag ("Enemy")) {
			Destroy(gameObject);
		}
	}
}
