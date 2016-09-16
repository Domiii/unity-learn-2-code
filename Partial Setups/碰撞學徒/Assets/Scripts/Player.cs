using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float speed = 3;
	public float jumpStrength = 9;
	public int colliderCount;

	void Update() {
		var body = GetComponent<Rigidbody2D> ();
		var v = body.velocity;

		v.x = Input.GetAxis ("Horizontal") * speed;

		if (Input.GetKeyDown (KeyCode.Space) && colliderCount > 0) {
			v.y = jumpStrength;
		}

		body.velocity = v;


		//  face current walking direction
		if (v.x != 0) {
			var scale = transform.localScale;
			scale.x = -Mathf.Sign (v.x) * Mathf.Abs(transform.localScale.x);
			transform.localScale = scale;
		}
	}

	void OnCollisionEnter2D(Collision2D collider) {
		++colliderCount;
	}

	void OnCollisionExit2D(Collision2D collider) {
		--colliderCount;
	}
}
