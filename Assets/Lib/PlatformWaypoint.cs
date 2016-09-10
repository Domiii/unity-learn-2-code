using UnityEngine;
using System.Collections;

public class PlatformWaypoint : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		var platform = other.GetComponent<Platform> ();
		if (platform != null) {
			
		}
	}
}
