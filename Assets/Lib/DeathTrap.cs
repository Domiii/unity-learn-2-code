using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathTrap : MonoBehaviour {
	public float speedFactor = 0.5f;

	void OnTriggerEnter2D(Collider2D other) {
		var triggerPlayer = other.GetComponent<Player> ();
		if (triggerPlayer != null) {
			// player entered! -> Lose!
			print("You lose!");
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	}
}