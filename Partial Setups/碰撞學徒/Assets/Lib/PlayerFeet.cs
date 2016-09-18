using UnityEngine;
using System.Collections;

public class PlayerFeet : MonoBehaviour {
	public Player player;

	void OnCollisionEnter2D(Collision2D collider) {
		++player.colliderCount;
	}

	void OnCollisionExit2D(Collision2D collider) {
		--player.colliderCount;
	}
}
