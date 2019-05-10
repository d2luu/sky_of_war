using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	public GameObject explosionEnemy;
	Vector2 prevPos; //vi tri truoc
	Vector2 currentPos; // vi tri sau
	int random;
	void Start () {
		//move allow the path
		iTween.MoveTo( this.gameObject , iTween.Hash ("path", PathController.path, "time", 10, "easetype", iTween.EaseType.linear));
		prevPos = transform.position;
		currentPos = prevPos;

	}


	public Vector2 dir;
	// Update is called once per frame
	void Update () 
	{
		
		//  xoay may bay theo vector tren..........................................//
		currentPos = prevPos;
		prevPos = transform.position;
		dir = currentPos - prevPos; //  vector huong di chuyen
		
		Vector3 angle = transform.localEulerAngles; 
		if (dir.y > 0 && dir.y != 0)
		{
			angle.z = - Mathf.Atan ( dir.x / dir.y) * Mathf.Rad2Deg;
		} else if(dir.y < 0 && dir.y != 0 && dir.x > 0)
		{
			angle.z = ( Mathf.Atan ( dir.x / - dir.y )+ 3.1415f )* Mathf.Rad2Deg;
		} else if(dir.y < 0 && dir.y != 0 && dir.x < 0)
		{
			angle.z = ( Mathf.Atan ( - dir.x /  dir.y )+ 3.1415f) * Mathf.Rad2Deg;
		}
		transform.localEulerAngles = angle;
		//.......................................................................//
		
		
		//destroy  when go out screeen
		Vector2 positon = transform.position;
		if(positon.y < -5.9f || positon.y > 7.9f || positon.x > 5.9f || positon.x < -5.9)
		{
			Destroy(this.gameObject);
		}


	
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player" || col.tag == "BulletPlayer" ) 
		{
			Instantiate(explosionEnemy,transform.position,transform.rotation);
			Destroy(gameObject);
		}
	}

	
	
}
