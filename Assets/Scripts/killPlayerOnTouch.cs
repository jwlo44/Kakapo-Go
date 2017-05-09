using UnityEngine;
using System.Collections;

public class killPlayerOnTouch : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			Debug.Log ("Touched Player");
			SingletonMusic.Instance.playThing(this.transform);
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
