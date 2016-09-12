using UnityEngine;
using System.Collections;

public class CameraMover : MonoBehaviour {
	public Vector2 move;
	Player player;

	void OnTriggerEnter2D(Collider2D collider) {
		var newPlayer = collider.GetComponent<Player>();
		if (newPlayer != null) {
			// player started colliding
			player = newPlayer;
		}
	}

	void OnTriggerExit2D(Collider2D collider) {
		if (collider.GetComponent<Player> () != null) {
			// player stopped colliding
			player = null;
		}
	}

	void FixedUpdate() {
		if (player) {
			var playerV = player.GetComponent<Rigidbody2D> ().velocity;
			var vx = playerV.x + player.pushSpeedX;		// the actual horizontal player speed
			Camera.main.transform.Translate (vx * Time.fixedDeltaTime, 0, 0);
		}
	}

//	void OnTriggerStay2D(Collider2D collider) {
//		if (collider.GetComponent<Player> () != null) {
//			// player collided with us
//			Camera.main.transform.Translate(move.x, move.y, 0);
//		}
//	}
}
