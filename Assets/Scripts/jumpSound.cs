using UnityEngine;
using System.Collections;

public class jumpSound : MonoBehaviour {

	public AudioClip jump;
	public AudioClip crazyJumpSound;
	private AudioClip choice;

	int countdownMax;
	int countdown;

	public move m;

	// Use this for initialization
	void Start () {
		if (globals.inCrazyMode) {
			choice = crazyJumpSound;
		} else {
			choice = jump;
		}
		countdownMax = (int) (10);
		countdown = 0;

		EventManager.Instance.OnPlayerJumped += (p) => 
		{
			AudioSource.PlayClipAtPoint(choice, transform.position);
			countdown = countdownMax;
		};
	}
	
	// Update is called once per frame
	void Update () { 
			if (countdown > 0){
				countdown--;
			}
		}
}
