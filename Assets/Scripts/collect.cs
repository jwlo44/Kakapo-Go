using UnityEngine;
using System.Collections;

public class collect : MonoBehaviour {
	
	move m = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (m != null) {
			if (m.getJumps() < m.getMaxJumps()) {
				m.incrementJumps();
				gameObject.SetActive(false);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
		    m = other.gameObject.GetComponent<move>();
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.tag == "Player") {
			m = null;
		}
	}
}
