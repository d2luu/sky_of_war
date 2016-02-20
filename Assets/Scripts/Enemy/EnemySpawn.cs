using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {


	public static Vector3 posSpawn;
	public GameObject enermy;
	// Use this for initialization
	void Start () {
		StartSpawnEnemy();
	}

	// Update is called once per frame
	void Update () {

	}

	
	public void SpawnEnemy()
	{

		GameObject taodich = (GameObject)Instantiate (enermy);

		taodich.transform.position = posSpawn;

		
	}
	public void StartSpawnEnemy()
	{
		InvokeRepeating("SpawnEnemy",5f, 2f);
	}

}	

