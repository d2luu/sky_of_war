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
<<<<<<< HEAD
=======


>>>>>>> df042f286c921f12598ab575554236bcf02bb7fe
}
