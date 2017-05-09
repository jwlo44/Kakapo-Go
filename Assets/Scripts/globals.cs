using UnityEngine;
using System.Collections;

public class globals : MonoBehaviour {
	public static bool inCrazyMode = false;
	static int checkpoint = 0;

	// Use this for initialization
	void Start () {
		if (Input.GetAxis ("Jump") != 0) {
			inCrazyMode = !inCrazyMode;
			Debug.Log("CRAZY MODE ACTIVATED");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
