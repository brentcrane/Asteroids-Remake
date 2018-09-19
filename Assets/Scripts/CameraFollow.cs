using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	GameObject target;

	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPos = target.transform.position;
		newPos.z = transform.position.z;
		transform.position = newPos;
	}
}
