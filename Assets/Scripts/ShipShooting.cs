using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShooting : MonoBehaviour {

	public GameObject laserPrefab;

	void Update ()
	{
		if (Input.GetButtonDown("Jump"))
		{
			Fire();
		}
	}

	void Fire ()
	{
		Instantiate(laserPrefab, transform.position, transform.rotation);
	}
}
