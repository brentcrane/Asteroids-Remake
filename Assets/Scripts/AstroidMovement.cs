using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidMovement : MonoBehaviour {

	public int minAsteroidStartHealth = 50;
	public int maxAsteroidStartHealth = 150;

	public int health = 100;
	public int minHealth = 10;

	private int maxHealth = 100;
	private Vector3 originalScale;
	private AsteroidManager manager;
	private Rigidbody2D rb;
	private float originalMass;

	private bool rolledHealth = false;

	void Start()
	{
		maxHealth = health;
		originalScale = transform.localScale;
		rb = GetComponent<Rigidbody2D>();
		originalMass = rb.mass;

		health = Random.Range(minAsteroidStartHealth, maxAsteroidStartHealth);
		Damage(0);
	}

	public void Damage(float amount)
	{
		health -= (int) amount;

		float scaleMult = (float) health / (float) maxHealth;
		Vector3 newScale = originalScale * scaleMult;
		newScale.z = originalScale.z;
		transform.localScale = newScale;
		rb.mass = originalMass * scaleMult;

		if (health <= minHealth)
		{
			GameObject managerGameObject = GameObject.FindGameObjectWithTag("Manager");
			manager = managerGameObject.GetComponent<AsteroidManager>();
			manager.DestroyAsteroid(gameObject);
		}
	}

}
