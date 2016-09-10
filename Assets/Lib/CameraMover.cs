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
			Camera.main.GetComponent<Rigidbody2D>().velocity = move * player.speed;
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
