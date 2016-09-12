using UnityEngine;
using System.Collections;

public class PlatformStation : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		//print (other.name);
		var platform = other.GetComponent<Platform> ();
		if (platform != null) {
			platform.speed = -platform.speed;
			if (platform.player != null) {
				platform.player.pushSpeedX += 2 * platform.speed;
			}
		}
	}
}
