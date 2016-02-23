using UnityEngine;
using System.Collections;

public abstract class Skill:MonoBehaviour{
	public float delay;
	public string name;
	public bool isPlay;
	public bool canPlay;
	public Vector2 position;
	abstract public void create();
	abstract public void playSkill();
}