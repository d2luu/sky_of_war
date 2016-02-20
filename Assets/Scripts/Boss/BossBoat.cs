using UnityEngine;
using System.Collections;
using UnityEditor;
public class BossBoat : Boss {
	int count = 216;
	public override void move(){
		//this.bossObj.GetComponent<Rigidbody2D>().velocity = transform.right.normalized * speed;
		Vector2 pos = bossObj.transform.position;
		if (pos.x == 3 || pos.x == -3)
			speed = -speed;
		pos +=new Vector2(0.01f,0f)  * speed;
		pos.x = Mathf.Clamp (pos.x, -3, 3);
		pos.y = Mathf.Clamp (pos.y, -3, 3);
		bossObj.transform.position = pos;
	}
	public override void bossUpdate () {
		skillManager ();
		move ();
		skill.position = new Vector2 (bossObj.transform.position.x, bossObj.transform.position.y-3f);
		if (count == 216) {
			skill.playSkill ();
			count=0;
		}
		count++; 
	}
	void OnTriggerEnter2D (Collider2D c){

	}
}
