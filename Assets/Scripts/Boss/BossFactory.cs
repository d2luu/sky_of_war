using UnityEngine;
using System.Collections;

public class BossFactory : MonoBehaviour {
	Boss boss;
	public  Boss getBoss(string bossName){
		GameObject bossObj = new GameObject ("boss");
		if (bossName.Equals ("Boat"))
			boss = bossObj.AddComponent<BossBoat> () as BossBoat;
		return this.boss;
	}
	public static BossFactory init(){
		GameObject bfObj = new GameObject ("bfObj");
		return bfObj.AddComponent <BossFactory>() as BossFactory;
	}
}
