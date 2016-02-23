using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour {

	enum GameState 
	{
		Playing,
		Pause
	}

	public GameObject spawnn;
	Text TimeUI; //reference to the timeCoterUI text
	float startTime;// time when click to play
	bool startCounter; //flag to start the counter

	GameState state = GameState.Playing;

	// Use this for initialization
	void Start () 
	{
		StartTimeCounter();

		TriggerEvent(2,ActionSecond5);
		TriggerEvent(4,ActionStopSpawnEnemy);

	}
	
	
	public void StartTimeCounter()
	{
		startTime = 0;
		startCounter = true;
	}
	
	//funtion to stop counter
	public void StopTimeCounter()
	{
		startCounter = false;
		
	}
	
	bool isEventTrigger = false;
	// Update is called once per frame
	void Update () 
	{
		if (state == GameState.Playing){
			startTime += Time.deltaTime;
		}

	}




	//thoi gian thuc hien Action
	public void TriggerEvent(float time, System.Action action){
		StartCoroutine(StartEvent(time, action));
	}
	//
	IEnumerator StartEvent(float startEvtTime, System.Action action){
		while (startEvtTime > startTime){
			Debug.Log("Current Time " + startTime);
			yield return new WaitForEndOfFrame();
		}
		action();
	}


	//Cai dat thoi gian enemy xuat hien theo kich ban.
	void ActionStopSpawnEnemy()
	{
		spawnn.GetComponent<EnemySpawn>().StopSpawnEnermy();
	}

	public void ActionSecond5()
	{
		spawnn.GetComponent<EnemySpawn>().StartSpawnEnemy(0,0.5f);


	}

	void Action2(){
		Debug.Log("Do acton 2");
	}
}
