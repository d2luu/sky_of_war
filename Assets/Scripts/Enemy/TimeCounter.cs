using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour {

	Text TimeUI; //reference to the timeCoterUI text
	float startTime;// time when click to play
	bool startCounter; //flag to start the counter

	
	
	// Use this for initialization
	void Start () 
	{
		startCounter = true;
	}
	
	
	public void StartTimeCounter()
	{
		startTime = Time.time;
		startCounter = true;
		
		
	}
	
	//funtion to stop counter
	public void StopTimeCounter()
	{
		startCounter = false;
		
	}
	
	
	// Update is called once per frame
	void Update () 
	{

	}
}
