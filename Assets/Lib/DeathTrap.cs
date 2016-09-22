using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathTrap : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other) {
		var triggerPlayer = other.GetComponentInParent<Player> ();
		if (triggerPlayer != null) {
			// player entered! -> Lose!
			print("You lose!");
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	}
}