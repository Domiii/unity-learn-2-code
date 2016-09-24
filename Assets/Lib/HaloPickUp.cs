using UnityEngine;
using System.Collections;

/// <summary>
/// Halo (光環)
/// </summary>
public class HaloPickUp : MonoBehaviour {
	public Player player;
	public Vector2 relativePosition = new Vector2(0, 1);
	public Vector2 hoverBounds = new Vector2(0.8f, 0.2f);
	public float hoverSpeed = 1f;
	Vector2 startPos;

	void Start() {
		startPos = transform.position;
	}

	void Update() {
		if (IsEquipped) {
			Hover ();

			if (Input.GetKeyDown (KeyCode.DownArrow)) {
				Unequip ();
			}
		}
	}

	void Hover() {
		var pos = player.transform.position + (Vector3)relativePosition;
		var theta = Time.time * 2 * Mathf.PI * hoverSpeed;
		pos.x += Mathf.Sin(theta) * hoverBounds.x;
		pos.y += Mathf.Cos(theta) * hoverBounds.y;
		transform.position = pos;
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (IsEquipped) {
			// don't do anything when already equipped
			return;
		}

		var triggerPlayer = other.GetComponentInParent<Player> ();
		if (triggerPlayer != null) {
			Equip (triggerPlayer);
		}
	}

	public bool IsEquipped {
		get {
			return player != null;
		}
	}

	void Equip(Player triggerPlayer) {
		player = triggerPlayer;
		transform.localScale /= 2;
	}

	/// <summary>
	/// Player dropped (放下) the halo
	/// </summary>
	void Unequip() {
		transform.localScale *= 2;
		player = null;
		transform.position = startPos;
	}
}
