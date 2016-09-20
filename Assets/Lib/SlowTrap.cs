using UnityEngine;
using System.Collections;

public class SlowTrap : MonoBehaviour {
	public float speedFactor = 0.5f;

	void OnTriggerEnter2D(Collider2D other) {
		var triggerPlayer = other.GetComponent<Player> ();
		if (triggerPlayer != null) {
			// player entered!
			triggerPlayer.speed *= speedFactor;
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		var triggerPlayer = other.GetComponent<Player> ();
		if (triggerPlayer != null) {
			// player exited!
			triggerPlayer.speed /= speedFactor;
		}
	}
}
