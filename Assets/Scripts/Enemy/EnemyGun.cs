using UnityEngine;
using System.Collections;

public class EnemyGun : MonoBehaviour {

	public GameObject enemyBullet; // pretabs
	
	// Use this for initialization
	void Start () {
		Invoke ("Fire", 1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void Fire()
		
	{
		GameObject ship = GameObject.Find("Player");
		
		if(ship != null)// player not dead
		{
			GameObject fireBullet = (GameObject)Instantiate(enemyBullet);
			fireBullet.transform.position = transform.position;
			
			//compute the Dan's derection towards the ship
			Vector2 direction = ship.transform.position - fireBullet.transform.position;
			// set direction
			fireBullet.GetComponent<EnemyBullet>().SetDirection(direction);
			
		}
	}
}

