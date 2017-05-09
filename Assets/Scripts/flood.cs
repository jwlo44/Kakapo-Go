using UnityEngine;
using System.Collections;

public class flood : MonoBehaviour {

	public move m;
	public Vector3 speed = new Vector3(0, 1, 0);
	public float speedyspeed = 2;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			if (Input.GetAxis("Jump") < 0) {
				Debug.Log("CRAZY MODE ACTIVATED");
				globals.inCrazyMode = !globals.inCrazyMode;
			}
			Application.LoadLevel(Application.loadedLevel);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (m.getJumps() == 0) {
			gameObject.transform.Translate (speed * speedyspeed);
		} else{
		transform.Translate (speed);
		}
}
}