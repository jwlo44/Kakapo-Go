using UnityEngine;
using System.Collections;

public class foofer : MonoBehaviour {

	public ParticleSystem foof;

	// Use this for initialization
	void Start () {

		EventManager.Instance.OnPlayerJumped += (p) => 
		{
			ParticleSystem.Instantiate(foof, this.gameObject.transform.position, Quaternion.identity);
		};
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
