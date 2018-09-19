using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserLogic : MonoBehaviour {

	public float laserSpeed = 30f;
	public float laserDamage = 25f;

	private GameObject player;
	private Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = transform.up * laserSpeed;
		player = GameObject.FindGameObjectWithTag("Player");
	}

	void Update () {
		if (transform.position.x > player.transform.position.x + 50f || transform.position.x < player.transform.position.x + -50f ||
			transform.position.y > player.transform.position.y + 50f || transform.position.y < player.transform.position.y + -50f)
		{
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "Asteroid")
		{
			//manager.DestroyAsteroid(col.gameObject);
			col.gameObject.GetComponent<AstroidMovement>().Damage(laserDamage);
			Destroy(gameObject);
		}
	}
}
