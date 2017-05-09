using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public class EventManager : MonoBehaviour {

	private static EventManager instance = null;
	public static EventManager Instance {
		get { return instance; }
	}
	void Awake() {
		if (instance != null && instance != this) {
			Destroy(this.gameObject);
			return;
		} else {
			instance = this;
		}
	}


	public delegate void PlayerJumpReaction(move player);
	public event PlayerJumpReaction OnPlayerJumped;

	public void RaiseJumpEvent(move player)
	{
		if (OnPlayerJumped != null) {
			OnPlayerJumped(player);
		}
	}
}
