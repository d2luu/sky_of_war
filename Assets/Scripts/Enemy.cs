using UnityEngine;
using System.Collections;

public abstract class Enemy :Vehicle{
	public int ID;
	public Sprite sprite;
	enum State {Dead,Life};
    int state;
	abstract public void move();
    public Enemy(){
       	state = (int)State.Life;
    }


}
