using UnityEngine;
using System.Collections;

public class PathController : MonoBehaviour {
	public static PathController instance;
	public GameObject[] pathList;
	public static Vector3[] path;//Duong bay
	int random;

	void Awake(){

		instance = this;
	}
	// Use this for initialization
	void Start () {
		getPathAirLine() ;
	}



	public Vector3[] getPathAirLine(){
	//	int random;
		random = Random.Range(0,14);
		EnemySpawn.posSpawn = pathList[random].GetComponent<iTweenPath>().nodes[0];
		path = iTweenPath.GetPath(pathList[random].name);
		return path;
	}

	void Update () {
		//getPathAirLine() ;
	}
}
