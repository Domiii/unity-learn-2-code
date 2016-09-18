using UnityEngine;
using System.Collections;

public class CameraMover : MonoBehaviour {
	public float xDirection;
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

	void Update() {
		if (player != null) {
			var xSpeed = xDirection * player.speed;
			Camera.main.transform.Translate (xSpeed * Time.deltaTime, 0, 0);
		}
	}

	void OnTriggerStay2D(Collider2D other) {
		var direction = (other.transform.position - transform.position).normalized;
		var triggerPlayer = other.gameObject.GetComponentInParent<Player> ();
		if (triggerPlayer == null) {
			other.transform.Translate (direction * 0.05f);
		}
	}

//	void OnTriggerStay2D(Collider2D other) {
//		var player = other.gameObject.GetComponentInParent<Player>();
//		if (player != null) {
//			Camera.main.transform.Translate (xDirection * player.speed * Time.deltaTime, 0, 0);
//		}
//	}
}
