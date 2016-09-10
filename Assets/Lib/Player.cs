using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float speed = 3;
	public float jumpStrength = 9;
	public int groundColliders;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var body = GetComponent<Rigidbody2D> ();
		var v = body.velocity;

		v.x = Input.GetAxis ("Horizontal") * speed;

		if (groundColliders > 0 && Input.GetKeyDown(KeyCode.Space)) {
			v.y = jumpStrength;
		}

		body.velocity = v;
	}
}
