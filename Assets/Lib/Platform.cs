using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {
	public float speed = 3;
	public Player player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		var move = Vector2.right * speed * Time.fixedDeltaTime;
		transform.Translate (move);
	}

	void OnTriggerEnter2D(Collider2D other) {
		var collisionPlayer = other.gameObject.GetComponent<Player> ();
		if (collisionPlayer != null) {
			// player entered platform
			player = collisionPlayer;
			player.pushSpeedX += speed;
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if (player != null) {
			var collisionPlayer = other.gameObject.GetComponent<Player> ();
			if (collisionPlayer == player) {
				// player left platform
				player.pushSpeedX -= speed;
				player = null;
			}
		}
	}
}
