using UnityEngine;
using System.Collections;

public abstract class Enemy :Vehicle{
	public int score;
	enum State {Dead,Life};
    int state;
	abstract public void move();
    public Enemy(){
       	state = (int)State.Life;
    }
}
