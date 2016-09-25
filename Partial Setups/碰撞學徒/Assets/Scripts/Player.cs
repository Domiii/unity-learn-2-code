using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float speed = 3;
	public int collisionCount;

	void Update() {
		var body = GetComponent<Rigidbody2D> ();
		var v = body.velocity;
		v.x = Input.GetAxis ("Horizontal") * speed;
		body.velocity = v;


		if (v.x != 0) {
			var scale = transform.localScale;
			scale.x = Mathf.Sign (v.x) * Mathf.Abs(transform.localScale.x);
			transform.localScale = scale;
		}
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
