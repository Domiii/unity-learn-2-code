using UnityEngine;
using System.Collections;

public class PlatformWaypoint : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		//print (other.name);
		var platform = other.GetComponent<Platform> ();
		if (platform != null) {
			platform.speed = -platform.speed;
			if (platform.player != null) {
				platform.player.pushSpeed += 2 * platform.speed;
			}
		}
	}
}
