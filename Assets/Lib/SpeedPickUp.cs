using UnityEngine;
using System.Collections;

public class SpeedPickUp : MonoBehaviour {
	public float speedFactor = 2;

	// 確認通知
	public GameObject confirmNotice;
	public Player player;

	void Start() {
		confirmNotice.SetActive (false);
	}

	void OnTriggerEnter2D(Collider2D other) {
		var triggerPlayer = other.GetComponentInParent<Player> ();
		if (triggerPlayer != null) {
			// player entered the PickUp
			player = triggerPlayer;
			confirmNotice.SetActive (true);
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		var triggerPlayer = other.GetComponentInParent<Player> ();
		if (triggerPlayer != null && triggerPlayer == player) {
			confirmNotice.SetActive (false);
			player = null;
		}
	}

	void Update() {
		if (player != null && Input.GetKeyDown(KeyCode.E)) {
			player.speed *= speedFactor;
			Destroy (gameObject);
		}
	}
}
