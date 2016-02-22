using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	Boss boss;
	// Use this for initialization
	void Start () {
		boss = BossFactory.init ().getBoss ("Boat");
		boss.create (2000, 3,"CreateWall","SubmerseRise","GunHit", "boss_boat");
		Debug.Log (Camera.main.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		boss.bossUpdate ();
	}
}
