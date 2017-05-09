using UnityEngine;
using System.Collections;

public class PlayerCrazyModeHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (globals.inCrazyMode) {
			this.gameObject.GetComponent<Rigidbody2D> ().freezeRotation = false;
		} else {
			this.gameObject.GetComponent<Rigidbody2D> ().freezeRotation = true;
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
