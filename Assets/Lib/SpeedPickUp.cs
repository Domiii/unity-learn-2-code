using UnityEngine;
using System.Collections;

public class SpeedPickUp : MonoBehaviour {
	public float speedFactor = 2;

	void OnTriggerEnter2D(Collider2D other) {
		var triggerPlayer = other.GetComponent<Player> ();
		if (triggerPlayer != null) {
			// player picked it up!	
			triggerPlayer.speed *= speedFactor;
			Destroy (gameObject);
		}
	}
}
