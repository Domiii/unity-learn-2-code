using UnityEngine;
using System.Collections;

public class PlayerFeet : MonoBehaviour {
	public Player player;

	void OnTriggerEnter2D(Collider2D collider) {
		print (collider.name);
		if (collider.gameObject != player) {
			++player.groundColliders;
		}
	}

	void OnTriggerExit2D(Collider2D collider) {
		if (collider.gameObject != player) {
			--player.groundColliders;
		}
	}
}
