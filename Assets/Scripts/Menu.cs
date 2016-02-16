using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	public GameObject waitImage;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ClickPlay() {
		StartCoroutine ("ClickPlayCo");
	}

	IEnumerator ClickPlayCo(){
		waitImage.SetActive (true);
<<<<<<< HEAD
=======
		//WaitForSeconds (2f);
>>>>>>> 7c7d4fea98caed90d23127e3df3c3899ea689664
		yield return new WaitForSeconds(2f);
		Debug.Log ("Chuyen man hinh");
		Application.LoadLevel ("Choose Map");

	}
}
