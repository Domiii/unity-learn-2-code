using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour {
	public float speed = 4;
	public int collisionCount;

	void Update () {
		var body = GetComponent<Rigidbody2D> ();
		var v = body.velocity;

		v.x = Input.GetAxis ("Horizontal") * speed;

		body.velocity = v;
	}

	void OnCollisionEnter2D(Collision2D other) {
		print ("Enter: " + other.gameObject.name);
		++collisionCount;
	}

	void OnCollisionStay2D(Collision2D other) {
		print ("Stay: " + other.gameObject.name);
	}

	void OnCollisionExit2D(Collision2D other) {
		print ("Exit: " + other.gameObject.name);
		--collisionCount;
	}
}
