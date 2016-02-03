using UnityEngine;
using System.Collections;

public abstract class Enemy :Vehicle{
	public int score;
	enum State {Dead,Life};
	abstract public void move();
}
