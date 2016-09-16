using UnityEngine;
using System.Collections;

public class SlowTrap : MonoBehaviour {
	public float speedFactor = 0.5f;

	void OnTriggerEnter2D(Collider2D other) {
		var enterPlayer = other.GetComponent<Player> ();
		if (enterPlayer != null) {
			// player entered!
			enterPlayer.speed *= speedFactor;
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		var exitPlayer = other.GetComponent<Player> ();
		if (exitPlayer != null) {
			// player exited!
			exitPlayer.speed /= speedFactor;
		}
	}
}
