using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float speed = 3;
	public float jumpStrength = 8;
	public int groundCollisions;

	void Update() {
		// 用鍵盤來控制左右移動
		var body = GetComponent<Rigidbody2D> ();
		var v = body.velocity;

		v.x = Input.GetAxis ("Horizontal") * speed;

		if (Input.GetKeyDown (KeyCode.Space) && groundCollisions > 0) {
			v.y = jumpStrength;
		}

		body.velocity = v;


		// 跟者角色走的方向改看的方向
		if (v.x != 0) {
			var scale = transform.localScale;
			scale.x = Mathf.Sign (v.x) * Mathf.Abs(transform.localScale.x);
			transform.localScale = scale;
		}
	}
}
