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
		var move = Vector3.right * speed * Time.fixedDeltaTime;
		transform.Translate (move);
//		if (player != null) {
//			//var body = player.GetComponent<Rigidbody2D> ();
//			//body.MovePosition (player.transform.position + move);
//			player.transform.Translate(move);
//		}
	}

	void OnCollisionEnter2D(Collision2D collision) {
		var collisionPlayer = collision.gameObject.GetComponent<Player> ();
		if (collisionPlayer != null) {
			// player entered platform
			player = collisionPlayer;
			player.pushSpeed += speed;
		}
	}

	void OnCollisionExit2D(Collision2D collision) {
		var collisionPlayer = collision.gameObject.GetComponent<Player> ();
		if (collisionPlayer == player) {
			// player left platform
			player.pushSpeed -= speed;
			player = null;
		}
	}
}
