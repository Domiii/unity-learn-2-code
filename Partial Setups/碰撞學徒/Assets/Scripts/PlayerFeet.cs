using UnityEngine;
using System.Collections;

public class PlayerFeet : MonoBehaviour {
	public Player player;

	void OnCollisionEnter2D(Collision2D other) {
		++player.groundCollisions;
	}

	void OnCollisionExit2D(Collision2D other) {
		--player.groundCollisions;
	}
}
