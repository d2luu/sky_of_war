using UnityEngine;
using System.Collections;

public class PathController : MonoBehaviour {
	public static PathController instance;
	//public static PathController instance;
	public GameObject[] pathList;
	//public static int indexPath;
	public static Vector3[] path;//Duong bay
	//int currentIndex;
	int random;

	void Awake(){

		instance = this;
	}
	// Use this for initialization
	void Start () {
	
	}
	//Duong Bay
	public void AirLine() 
	{
		random=Random.Range(0,14);
		if(random == 0){
			EnemySpawn.posSpawn = pathList[0].GetComponent<iTweenPath>().nodes[0];
		    path = iTweenPath.GetPath("Line1");

		}
		else if(random==1)
		{
			EnemySpawn.posSpawn = pathList[1].GetComponent<iTweenPath>().nodes[0];
			path = iTweenPath.GetPath("Line301");

		}
		else if(random==2)
		{
			EnemySpawn.posSpawn = pathList[2].GetComponent<iTweenPath>().nodes[0];
			path = iTweenPath.GetPath("Line302");

		}
		else if(random==3)
		{
			EnemySpawn.posSpawn = pathList[3].GetComponent<iTweenPath>().nodes[0];
			path = iTweenPath.GetPath("Line401");

		}
		else if(random==4)
		{
			EnemySpawn.posSpawn = pathList[4].GetComponent<iTweenPath>().nodes[0];
			path = iTweenPath.GetPath("Line402");
		
		}
		else if(random==5)
		{
			EnemySpawn.posSpawn = pathList[5].GetComponent<iTweenPath>().nodes[0];
			path = iTweenPath.GetPath("Line403");

		}else if(random==6)
		{
			EnemySpawn.posSpawn = pathList[6].GetComponent<iTweenPath>().nodes[0];
			path = iTweenPath.GetPath("Line404");

		}else if(random==7)
		{
			EnemySpawn.posSpawn = pathList[7].GetComponent<iTweenPath>().nodes[0];
			path = iTweenPath.GetPath("Line405");

		}
		else if(random==8)
		{
			EnemySpawn.posSpawn = pathList[8].GetComponent<iTweenPath>().nodes[0];
			path = iTweenPath.GetPath("Line406");

		}
		else if(random==9)
		{
			EnemySpawn.posSpawn = pathList[9].GetComponent<iTweenPath>().nodes[0];
			path = iTweenPath.GetPath("Line407");

		}
		else if(random==10)
		{
			EnemySpawn.posSpawn = pathList[10].GetComponent<iTweenPath>().nodes[0];
			path = iTweenPath.GetPath("Line408");

		}else if(random==11)
		{
			EnemySpawn.posSpawn = pathList[11].GetComponent<iTweenPath>().nodes[0];
			path = iTweenPath.GetPath("Line8");

		}else if(random==12)
		{
			EnemySpawn.posSpawn = pathList[12].GetComponent<iTweenPath>().nodes[0];
			path = iTweenPath.GetPath("Line901");

		}else if(random==13)
		{
			EnemySpawn.posSpawn = pathList[13].GetComponent<iTweenPath>().nodes[0];
			path = iTweenPath.GetPath("Line902");

		}
	


	}

	//public Vector3 getPath(int path){
	//	EnemySpawn.posSpawn = pathList[path].GetComponent<iTweenPath>().nodes[0];
	//	path = iTweenPath.GetPath(pathList[path].name);
	//}

	void Update () {
		AirLine() ;
	}
}
