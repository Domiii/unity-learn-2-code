using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Platform : MonoBehaviour {
	public float speed = 3;

	void FixedUpdate () {
		var move = Vector2.right * speed * Time.fixedDeltaTime;
		transform.Translate (move);
	}
}
