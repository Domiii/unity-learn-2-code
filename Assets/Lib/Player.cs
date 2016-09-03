using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float speed = 3;
	public float jumpStrength = 5;
	public bool isOnGround = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var body = GetComponent<Rigidbody2D> ();

		var v = Vector2.right * Input.GetAxis ("Horizontal") * speed;
		v.y = body.velocity.y;

		if (isOnGround && Input.GetKeyDown(KeyCode.Space)) {
			v.y = jumpStrength;
		}

		body.velocity = v;
	}
}
