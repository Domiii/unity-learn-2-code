using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {
	public float speed = 3;

	void FixedUpdate () {
		var move = Vector2.right * speed * Time.fixedDeltaTime;
		transform.Translate (move);
	}
}
