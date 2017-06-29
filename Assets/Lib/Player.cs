using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float speed = 3;
	public float visSpeed;
	public float jumpStrength = 9;
	public Platform platform;
	public int groundColliders;
	bool jumping;

	// Use this for initialization
	void Start () {
	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.Space) && groundColliders > 0) {
			jumping = true;
		}
		var body = GetComponent<Rigidbody2D> ();
		var v = body.velocity;
		visSpeed = v.x;
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

		if (v.x != 0) {
			var dir = Mathf.Sign (v.x);
			transform.rotation = Quaternion.Euler (0, 90 - dir * 90, 0);
		}
	}
}
