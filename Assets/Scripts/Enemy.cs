using UnityEngine;
using System.Collections;

public abstract class Enemy :Vehicle{
	public int score;
	enum State {Dead,Life};
<<<<<<< HEAD
	abstract public void move();
=======
    int state;
	abstract public void move();
    public Enemy(){
       	state = (int)State.Life;
    }
>>>>>>> e0903e7e6a561243c138a133852fa0d8a1a199e3
}
