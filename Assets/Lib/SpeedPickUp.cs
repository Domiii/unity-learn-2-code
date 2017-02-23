using UnityEngine;
using System.Collections;

public class SpeedPickUp : MonoBehaviour {
	// player speed multiplier when picked up
	public float speedFactor = 2;
	// 確認通知
	public GameObject confirmNotice;
	
	Player player;

	void Update() {
		if (player != null && Input.GetKeyDown(KeyCode.E)) {
			player.speed *= speedFactor;
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		// maybe you have to change GetComponentInParent to GetComponent
		var triggerPlayer = other.GetComponentInParent<Player> ();
		if (triggerPlayer != null) {
			// player entered the PickUp
			player = triggerPlayer;
			confirmNotice.SetActive (true);
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		// maybe you have to change GetComponentInParent to GetComponent
		var triggerPlayer = other.GetComponentInParent<Player> ();
		if (triggerPlayer != null && triggerPlayer == player) {
			confirmNotice.SetActive (false);
			player = null;
		}
	}
}
