using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidDestroyer : MonoBehaviour {

	public AsteroidManager manager;

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Asteroid")
			manager.DestroyAsteroid(col.gameObject);
	}

}
