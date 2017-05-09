using UnityEngine;
using System.Collections;

public class SingletonMusic : MonoBehaviour {
	public AudioClip dieSound;

	private static SingletonMusic instance = null;
	public static SingletonMusic Instance {
		get { return instance; }
	}
	void Awake() {
		if (instance != null && instance != this) {
			Destroy(this.gameObject);
			return;
		} else {
			instance = this;
			AudioSource src = instance.gameObject.GetComponent<AudioSource> ();
			src.Play();
		}
		DontDestroyOnLoad(this.gameObject);
	}
	public void playThing(Transform t){
			AudioSource.PlayClipAtPoint (dieSound, t.position);
	}
}
