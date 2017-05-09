using UnityEngine;
using System.Collections;

public class kakapoSpawn : MonoBehaviour {

	
	public AudioClip boom;
	public AudioClip crazyBoom;
	public AudioClip ladygaga;

	public GameObject kakapo_joe;
	public GameObject musicNote;
	public GameObject musicNote2;

	// Use this for initialization
	void Start () {
		StartCoroutine (playSounds ());
	}

	IEnumerator playSounds() {
		// play a sound depending on the mode
		if (globals.inCrazyMode) {
			AudioSource.PlayClipAtPoint (crazyBoom, this.transform.position);
		} else {
			AudioSource.PlayClipAtPoint (boom, this.transform.position);
		}
		musicNote.SetActive (true);
		yield return new WaitForSeconds (boom.length);
		
		// play lady sound
		musicNote.SetActive(false);
		if (globals.inCrazyMode) {
			AudioSource.PlayClipAtPoint (crazyBoom, this.transform.position);
		} else {
			AudioSource.PlayClipAtPoint (ladygaga, this.transform.position);
		}
		musicNote2.SetActive (true);
		yield return new WaitForSeconds (ladygaga.length);
		
		musicNote2.SetActive(false);
		kakapo_joe.SetActive (true);
		Debug.Log ("activated!");
		gameObject.SetActive (false);
		yield return null;
	}

	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("Jump") < 0) {
			musicNote.SetActive(false);
			musicNote2.SetActive(false);
			kakapo_joe.SetActive(true);
			gameObject.SetActive(false);
		}
	}
}
