using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {
	public float timeDes;
	void Start()
	{
		Destroy (gameObject, timeDes);
	}
}
