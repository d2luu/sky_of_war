using UnityEngine;
using System.Collections;

public class Vehicle :MonoBehaviour{
	public float speed;
	public int healthy;
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
