using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float speed = 3;
	public float pushSpeed;
	public float jumpStrength = 9;
	public int groundColliders;
	bool jumping;

	// Use this for initialization
	void Start () {
	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.Space) && groundColliders > 0) {
			jumping = true;
		}
	}

	void FixedUpdate () {
		var body = GetComponent<Rigidbody2D> ();
		var v = body.velocity;

		v.x = Input.GetAxis ("Horizontal") * speed;

		if (jumping) {
			v.y = jumpStrength;
			jumping = false;
		}

		body.velocity = v;
		transform.Translate (pushSpeed * Time.fixedDeltaTime, 0, 0);
	}
}
