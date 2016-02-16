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
		yield return new WaitForSeconds(2f);
		Debug.Log ("Chuyen man hinh");
		Application.LoadLevel ("Choose Map");

	}
}
