using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {


	public static Vector3 posSpawn;
	public GameObject enermy;
	// Use this for initialization
	void Start () {
		//InvokeRepeating("SpawnEnemy",0, 2f);
		//StartSpawnEnemy();
	//	TimeCounter a = new TimeCounter();
		//a.TriggerEvent(5, StartSpawnEnemy);
	}

	// Update is called once per frame
	void Update () {

	}

	
	public void SpawnEnemy()
	{

		GameObject spEnemy = (GameObject)Instantiate (enermy);

		spEnemy.transform.position = posSpawn;

		
	}
	public void StartSpawnEnemy(float a, float b)
	{
		InvokeRepeating("SpawnEnemy",a, b);
	}
	public void StopSpawnEnermy()
	{
		CancelInvoke("SpawnEnermy");
	}

	/*public void ActionSecond5()
	{
		StartSpawnEnemy(0f,0.5f);
	/*	if(TimeCounter.startTime == 7)
		{
			StopSpawnEnermy();
		}

	}

	public void TriggerEvent(float time, System.Action action){
		StartCoroutine(StartEvent(time, action));
	}

	IEnumerator StartEvent(float startEvtTime, System.Action action){

		while (startEvtTime > TimeCounter.startTime){
			Debug.Log("Current Time " + TimeCounter.startTime);
			yield return new WaitForEndOfFrame();
		}

		action();
	}
	*/
}	

