using UnityEngine;
using System.Collections;

public class CameraMover : MonoBehaviour {
	public Vector2 move;
	public Vector2 v;
	Player player;

	void OnTriggerEnter2D(Collider2D collider) {
		var newPlayer = collider.GetComponent<Player>();
		if (newPlayer != null) {
			// player started colliding
			player = newPlayer;
			var playerV = player.GetComponent<Rigidbody2D> ().velocity;
			v.x = Mathf.Abs(move.x) * (player.pushSpeed + playerV.x);
			v.y = Mathf.Abs(move.y) * playerV.y;
			Camera.main.GetComponent<Rigidbody2D>().velocity = v;
		}
	}

	void OnTriggerExit2D(Collider2D collider) {
		if (collider.GetComponent<Player> () != null) {
			// player stopped colliding
			player = null;
			Camera.main.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		}
	}

	void Update() {
		if (player) {
			//Camera.main.transform.Translate(move.x, move.y, 0);
		}
	}

//	void OnTriggerStay2D(Collider2D collider) {
//		if (collider.GetComponent<Player> () != null) {
//			// player collided with us
//			Camera.main.transform.Translate(move.x, move.y, 0);
//		}
//	}
}
