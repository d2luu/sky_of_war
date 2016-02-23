using UnityEngine;
using System.Collections;

public class BulletEnemy : Bullet {

	public static BulletEnemy instance;
	// Use this for initialization
	void Start () {
		instance = this;
		GetComponent<Rigidbody2D> ().velocity = transform.up * speed;
	}
	void Update(){
		Destroy (gameObject, bullet_time_remove);
	}
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D col) {
		if(col.gameObject.CompareTag("Player")){
			Instantiate(explosion,transform.position,transform.rotation);
			Destroy(gameObject);
		}

	}
}
