using UnityEngine;
using System.Collections;

public class PlayerFeet : MonoBehaviour {
	public Player player;

	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject != player) {
			++player.groundColliders;
		}
	}

	void OnCollisionStay2D(Collision2D other) {
		// check if play is on platform
		var triggerPlatform = other.gameObject.GetComponentInParent<Platform> ();
		if (triggerPlatform != null) {
			player.platform = triggerPlatform;
			player.transform.parent = player.platform.transform;
		}
	}

	void OnCollisionExit2D(Collision2D other) {
		if (other.gameObject != player) {
			--player.groundColliders;
		}

		var triggerPlatform = other.gameObject.GetComponentInParent<Platform> ();
		if (triggerPlatform != null && triggerPlatform == player.platform) {
			// player left platform
			player.platform = null;
			player.transform.parent = null;
		}
	}
}