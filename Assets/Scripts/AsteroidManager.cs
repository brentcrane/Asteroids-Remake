using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour {


	public GameObject boundTop;
	public GameObject boundBottom;
	public GameObject boundLeft;
	public GameObject boundRight;

	public GameObject asteroidMedium;
	public List<GameObject> asteroids = new List<GameObject>();

	public float asteroidSpawnDelay = 3f;
	private float lastSpawn = 0f;

	public int maxAsteroids = 10;


	void Update () {
		if (Time.time-lastSpawn > asteroidSpawnDelay && asteroids.Count < maxAsteroids)
		{
			SpawnAsteroid();
			lastSpawn = Time.time;
		}
	}

	void SpawnAsteroid()
	{
		GameObject newAsteroid = Instantiate(asteroidMedium, new Vector2(-20,-20), Quaternion.identity);

		float randomX = Random.Range(boundLeft.transform.position.x, boundRight.transform.position.x);
		float randomY = Random.Range(boundTop.transform.position.y, boundBottom.transform.position.y);
		float startPosX = 0f;
		float startPosY = 0f;
		float velX = 0f;
		float velY = 0f;

		int directionPick = Random.Range(0,4);
		switch (directionPick)
		{
			case 0: // Top
				startPosY = boundTop.transform.position.y;
				startPosX = randomX;
				break;
			case 1: // Bottom
				startPosY = boundBottom.transform.position.y;
				startPosX = randomX;
				break;
			case 2: // Left
				startPosX = boundLeft.transform.position.x;
				startPosY = randomY;
				break;
			case 3: // Right
				startPosX = boundRight.transform.position.x;
				startPosY = randomY;
				break;
		}


		if (startPosX < 0)
			velX = Random.Range(2f, 5f);
		else
			velX = Random.Range(-5f, -2f);

		if (startPosY < 0)
			velY = Random.Range(2f, 5f);
		else
			velY = Random.Range(-5f, -2f);


		newAsteroid.transform.position = new Vector2(startPosX, startPosY);

		Rigidbody2D rb = newAsteroid.GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2(velX, velY);
		rb.AddTorque(Random.Range(-3f, 3f));

		asteroids.Add(newAsteroid);
	}

	public void DestroyAsteroid(GameObject a)
	{
		asteroids.Remove(a);
		Destroy(a);
	}
}
