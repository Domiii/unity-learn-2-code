using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
	public float SecondsSinceStart;

	void Update () {
		SecondsSinceStart += Time.deltaTime;
	}
}
