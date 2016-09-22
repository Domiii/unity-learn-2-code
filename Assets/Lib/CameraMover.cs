using UnityEngine;
using System.Collections;

public class CameraMover : MonoBehaviour {
	public Vector2 move;
	Player player;

	void OnTriggerEnter2D(Collider2D other) {
		var triggerPlayer = other.gameObject.GetComponentInParent<Player> ();
		if (triggerPlayer != null) {
			player = triggerPlayer;
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		var triggerPlayer = other.gameObject.GetComponentInParent<Player> ();
		if (triggerPlayer != null) {
			player = null;
		}
	}

//	void FixedUpdate() {
//		if (player) {
//			var playerV = player.GetComponent<Rigidbody2D> ().velocity;
//			var vx = Mathf.Abs(playerV.x);		// the actual horizontal player speed
//
//			var platform = player.platform;
//			if (platform != null) {
//				vx += Mathf.Abs(platform.speed);
//			}
//
//			Camera.main.transform.Translate (move.x * vx * Time.fixedDeltaTime, 0, 0);
//		}
//	}
	void FixedUpdate() {
		if (player) {
			var playerV = player.GetComponent<Rigidbody2D> ().velocity;
			var delta = move;
			delta.x *= Mathf.Abs(playerV.x);		// the actual horizontal player speed
			delta.y *= Mathf.Abs(playerV.y);

			var platform = player.platform;
			if (platform != null) {
				delta.x += Mathf.Abs(platform.speed);
			}

			Camera.main.transform.Translate (delta * Time.fixedDeltaTime);
		}
	}
}
