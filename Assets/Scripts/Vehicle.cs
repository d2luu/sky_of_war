using UnityEngine;
using System.Collections;
// yeu cau phai co thanh phan Rigidbody2D
[RequireComponent(typeof(Rigidbody2D))]
public class Vehicle : MonoBehaviour{
	public float speed;
	public int healthy;
	public float shotDelay;
	public GameObject bullet;
	public GameObject explosion;

	//hieu ung no
	//public void Explosion(){
	//	Instantiate (explosion,transform.position,transform.rotation);
	//}

	// move palayer
	public void Move (Vector2 direction){
		GetComponent<Rigidbody2D> ().velocity = direction * speed;
	}

	// tao dan
	public void Shot (Transform origin){
		Instantiate (bullet,origin.position,origin.rotation);
	}
	public bool checkDestroy(){
		if (healthy <= 0) {
			return true;
		}
		return false;
	}
	public void plugHealth(int HP){
		healthy += HP;
	}
	//Phuong thuc destroy() sau se viet them khi tiem hieu ve animation
}
 