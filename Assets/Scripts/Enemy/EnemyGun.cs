using UnityEngine;
using System.Collections;

public class EnemyGun : MonoBehaviour {

	public GameObject enemybullet; // prefabs
	
	// Use this for initialization
	void Start () {
		InvokeRepeating ("Fire", 1f, 3.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void Fire()

	{
		GameObject player = GameObject.Find("Player");
		
		if(player != null)// player not dead
		{
			GameObject fireBullet = (GameObject)Instantiate(enemybullet);
			fireBullet.transform.position = this.transform.position;
			
			//compute the Dan's derection towards the ship
			Vector2 direction = player.transform.position - fireBullet.transform.position;
			// set direction
			fireBullet.GetComponent<BulletEnemy>().SetDirection(direction);
			
		}
	}
}

