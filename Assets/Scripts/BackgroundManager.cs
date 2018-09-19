using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour {

	public GameObject bg1;
	public GameObject bg2;
	public GameObject bg3;
	public GameObject bg4;

	public GameObject[] bgs;

	public Transform target;

	public float xDist = 12f;
	public float yDist = 9f;

	// Use this for initialization
	void Start () {
		bgs = new GameObject[] {bg1, bg2, bg3, bg4};
	}
	
	// Update is called once per frame
	void Update () {

		/*
		if (target.position.x - bg1.transform.position.x > xDist*2f)
			bg1.transform.Translate(new Vector3(4f * xDist, 0f, 0f));
		if (target.position.x - bg1.transform.position.x < -xDist*2f)
			bg1.transform.Translate(new Vector3(-4f * xDist, 0f, 0f));
		if (target.position.y - bg1.transform.position.y > yDist*2f)
			bg1.transform.Translate(new Vector3(0f, 4f * yDist, 0f));
		if (target.position.y - bg1.transform.position.y < -yDist*2f)
			bg1.transform.Translate(new Vector3(0f, -4f * yDist, 0f));
		*/

		for (int i = 0; i < bgs.Length; i++)
		{
			if (target.position.x - bgs[i].transform.position.x > xDist*2f)
				bgs[i].transform.Translate(new Vector3(4f * xDist, 0f, 0f));
			if (target.position.x - bgs[i].transform.position.x < -xDist*2f)
				bgs[i].transform.Translate(new Vector3(-4f * xDist, 0f, 0f));
			if (target.position.y - bgs[i].transform.position.y > yDist*2f)
				bgs[i].transform.Translate(new Vector3(0f, 4f * yDist, 0f));
			if (target.position.y - bgs[i].transform.position.y < -yDist*2f)
				bgs[i].transform.Translate(new Vector3(0f, -4f * yDist, 0f));
		}
	
		
	}
}
