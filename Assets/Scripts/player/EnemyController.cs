using UnityEngine;
using System.Collections;

public class EnemyController: Vehicle{

	// Use this for initialization
	IEnumerator Start () {
		Move (transform.up*-1);
		while (true) {
			for(int i=0 ; i< transform.childCount;i++){
				Transform shotPosition = transform.GetChild(i);
				Shot(shotPosition);
			}
			yield return new WaitForSeconds (shotDelay);

		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.CompareTag ("Player")) {
			Instantiate (explosion,transform.position,transform.rotation);
			Destroy(gameObject);
		}
	}
}
