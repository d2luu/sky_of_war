using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public int speed = 10;
	public GameObject explosion;
	void Start ()
	{

		// move bullet
		GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.CompareTag ("Player")) {
			Instantiate (explosion,transform.position,transform.rotation);
			Destroy(gameObject);
		}
	}
}
