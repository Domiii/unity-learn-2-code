using UnityEngine;
using System.Collections;

public class Rock : MonoBehaviour {
	public GameObject cat;
	public float catSpeed;
	public float catGravity;

	void OnMouseDown() {
		cat.GetComponent<Rigidbody2D> ().velocity = Vector2.right * catSpeed;
		cat.GetComponent<Rigidbody2D> ().gravityScale = catGravity;
	}
}
