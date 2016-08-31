using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour {
	public float Speed = 10;

	void Update() {
		var body = GetComponent<Rigidbody2D>();

		body.velocity = Vector2.right * Input.GetAxis ("Horizontal") * Speed +
						Vector2.up * Input.GetAxis ("Vertical") * Speed;
	}
		
		


	void OnMouseDown() {
		GetComponent<Rigidbody2D> ().gravityScale = 1;
		GetComponent<Rigidbody2D> ().velocity = Vector2.right * Speed;
	}
}
