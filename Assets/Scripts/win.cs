using UnityEngine;
using System.Collections;

public class win : MonoBehaviour {
	public GameObject layingDown;
	public AudioClip winSound;
	public AudioClip boom;
	public GameObject musicNote;
	public GameObject flood;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			flood.SetActive(false);
			StartCoroutine(WinSequence(other.gameObject));
		}
	}

	IEnumerator WinSequence(GameObject other) {
		GameObject.Instantiate (layingDown, other.transform.position, Quaternion.identity);
		AudioSource.PlayClipAtPoint (boom, this.gameObject.transform.position);
		other.gameObject.SetActive (false);
		yield return new WaitForSeconds(boom.length);

		musicNote.SetActive (true);
		AudioSource.PlayClipAtPoint (winSound, this.transform.position);
		yield return new WaitForSeconds(winSound.length);

		musicNote.SetActive (false);
		Application.LoadLevel (Application.loadedLevel + 1);
	}
}
