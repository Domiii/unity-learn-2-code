using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour {
	public float speed = 8.0f;

	void Update () {
		var body = GetComponent<Rigidbody2D> ();
		var v = body.velocity;

		// 軸線
		v.x = Input.GetAxis("Horizontal") * speed;

		body.velocity = v;
	}
}