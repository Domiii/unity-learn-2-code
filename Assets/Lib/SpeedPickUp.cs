using UnityEngine;
using System.Collections;

public class SpeedPickUp : MonoBehaviour {
	public float speedFactor = 2;

	void OnTriggerEnter2D(Collider2D other) {
		var enterPlayer = other.GetComponent<Player> ();
		if (enterPlayer != null) {
			// player picked it up!	
			enterPlayer.speed *= speedFactor;
			Destroy (gameObject);
		}
	}
}
