using UnityEngine;
using System.Collections;

public class PlayerController : Vehicle {

	public float shotDelay;	
	public GameObject bullet;
	public GameObject explosion;
	Animator anim;
	float x,y;
	float swipeSpeed;
	Vector2 prevMousePos,currentMousePos;
	// 
	IEnumerator Start(){
		anim = GetComponent<Animator> ();
		while (true) {
			if (Input.GetMouseButton (0)){
				Shot(transform);
			}
			yield return new WaitForSeconds(shotDelay);
		}
	}
	
	void Update ()
	{
		prevMousePos    = currentMousePos;
		currentMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		
		float swipeSpeed = (currentMousePos - prevMousePos).magnitude / Time.deltaTime;
		//Debug.Log ("Toc do chuot"+ swipeSpeed);

		Vector2 direction = (currentMousePos - prevMousePos).normalized;
		
		// xu ly cac animation cua player

		if (Input.GetMouseButton (0)){

			// get animaion move player
			//GetAnimationPlayer();
			// animation bay sang phai
			if(currentMousePos.x > prevMousePos.x && swipeSpeed > 4){
				anim.SetBool("Left",false);
				anim.SetBool("Right",true);
			}
			
			// anition bay sang trai
			if(currentMousePos.x < prevMousePos.x && swipeSpeed > 4){
				anim.SetBool("Right",false);
				anim.SetBool("Left",true);
			}
			// animation dung yen va di chuyen thang
			if((swipeSpeed==0)|| (currentMousePos.x == prevMousePos.x)){
				anim.SetBool("Left",false);
				anim.SetBool("Right",false);
			}

			MovePlayer (direction, swipeSpeed);
		}

	}

	// move player
	public void MovePlayer (Vector2 direction, float swipeSpeed){

		// set vi tri co dinh khung nhin
		Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2(-0.05f,0));
		Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2(1.05f,1));

		Vector2 pos = transform.position;

		//update vi tri cua player
		pos  += direction * swipeSpeed * (Time.deltaTime)*speed;

		// gioi han vi tri cua player theo khung man hinh
		pos.x = Mathf.Clamp (pos.x, min.x, max.x);
		pos.y = Mathf.Clamp (pos.y, min.y, max.y);

		transform.position = pos;
	
	}


	// xet va cham voi vien dan cua dich
	void OnTriggerEnter2D(Collider2D col)
	{

		if(col.gameObject.CompareTag("BulletEnemy")){
			plugHealth(-BulletEnemy.instance.dam);
			//anim.SetBool("CameraVibrate",true);
			//Debug.Log("Mau:"+healthy);
		}
		if (col.gameObject.CompareTag ("Enemy")) {
			plugHealth(-15);
			//StartCoroutine(Vibrate());
		}
		if (col.gameObject.CompareTag ("ProtectItem")) {
			//anim.SetBool("Shield",true);
			//Debug.Log("co an protect");
		}
		if(col.gameObject.CompareTag("BloodItem")){
			plugHealth(+30);
		}

		if(checkDestroy()){
			Destroy(gameObject);
		}
		//if (healthy < 20 && healthy >10) {
		//	anim.SetBool();
		//}
	}

	// get animation

	public void GetAnimationPlayer(){
		// animation bay sang phai
		if(currentMousePos.x > prevMousePos.x){
			anim.SetBool("Left",false);
			anim.SetBool("Right",true);
		}
		
		// anition bay sang trai
		if(currentMousePos.x < prevMousePos.x){
			anim.SetBool("Right",false);
			anim.SetBool("Left",true);
		}
		// animation dung yen va di chuyen thang
		if((swipeSpeed==0)|| (currentMousePos.x == prevMousePos.x)){
			anim.SetBool("Left",false);
			anim.SetBool("Right",false);
		}
	}
	/*
	IEnumerator Vibrate()
	{
		cameraObject.orthographicSize = 5.1f;
		Debug.Log("zoom");
		yield return new WaitForSeconds (0.1f);
		cameraObject.orthographicSize = 5f;
	}
	*/
	
	// tao dan
	public void Shot (Transform origin){
		Instantiate (bullet,origin.position,origin.rotation);
	}
}
