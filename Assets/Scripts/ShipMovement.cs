using UnityEngine;

public class ShipMovement : MonoBehaviour {

	public GameObject ship;
	public GameObject heading;

	public float shipSpeed = 1f;
	public float tiltSpeed = 1f;
	public float rotationalSpeed = 1f;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        // Ship movement
		float vert = Input.GetAxis("Vertical");
        Vector2 facing = heading.transform.position - transform.position;
		rb.AddForce (facing * shipSpeed * vert * Time.deltaTime);

		// Ship rotation
		float turn = Input.GetAxis("Horizontal");
		rb.angularVelocity = -turn * rotationalSpeed;

		// Side-to-side movement
		float tilt = Input.GetAxis("Tilt");
		rb.AddRelativeForce(new Vector2 (tiltSpeed * Time.deltaTime * tilt, 0));

    }
}
