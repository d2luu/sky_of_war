using UnityEngine;
using System.Collections;

public class PlayerController : Vehicle {

	// 
	IEnumerator Start(){
		while (true) {
			Shot(transform);
			yield return new WaitForSeconds(shotDelay);
		}


	}

		void Update ()
		{
			// 右・左
			float x = Input.GetAxisRaw ("Horizontal");
			
			// 上・下
			float y = Input.GetAxisRaw ("Vertical");
			
			// 移動する向きを求める
			Vector2 direction = new Vector2 (x, y).normalized;
			
			// 移動する向きとスピードを代入する
			Move (direction);
		}
	// xet va cham voi vien dan cua dich
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.CompareTag("BulletEnemy")){
			plugHealth(-5);
		}
		if (col.gameObject.CompareTag ("Enemy")) {
			plugHealth(-15);
		}
		if(checkDestroy()){
			Destroy(gameObject);
		}
	}
}
