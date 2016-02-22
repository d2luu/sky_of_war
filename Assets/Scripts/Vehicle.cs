using UnityEngine;
using System.Collections;

<<<<<<< HEAD
=======

>>>>>>> e0903e7e6a561243c138a133852fa0d8a1a199e3
// yeu cau phai co thanh phan Rigidbody2D
[RequireComponent(typeof(Rigidbody2D))]
public class Vehicle : MonoBehaviour{
	public float speed;
	public float healthy;
	public bool checkDestroy(){
		if (healthy <= 0) {
			return true;
		}
		return false;
	}
	public void plugHealth(float HP){
		healthy += HP;
		Debug.Log("Healthy:" + healthy);
	}
}
 