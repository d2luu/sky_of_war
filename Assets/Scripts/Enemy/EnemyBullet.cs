using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {
	float speed ;
	Vector2 _direction;
	bool isReady;
	
	
	void Awake()
	{
		speed = 5f;
		isReady = false;
	}
	
	// Use this for initialization
	void Start () {
		
		
	}
	
	public void SetDirection(Vector2 direction)
	{
		_direction = direction.normalized;
		
		
		isReady = true; // set flag to true
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(isReady){
			//lay vi tri dau tien
			Vector2 position = transform.position;
			// tinh toan vi tr moi
			position += _direction * speed * Time.deltaTime;
			//update vi tri
			transform.position = position;
			
			Vector2 positon = transform.position;
			if(positon.y < -5.9f || positon.y > 7.9f || positon.x > 5.9f || positon.x < -5.9)
			{
				Destroy(this.gameObject);
			}

			
		}
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player") 
		{
			Destroy (gameObject);
		}
	}
	

}
