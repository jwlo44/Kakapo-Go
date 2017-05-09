using UnityEngine;
using System.Collections;

public class ui : MonoBehaviour {
	public move m;
	private GUIStyle myStyle = new GUIStyle();

	void Start(){
		myStyle.fontSize = 72;
		myStyle.fontStyle = FontStyle.Bold;
	}

	void OnGUI(){
		GUILayout.Label (m.getJumps().ToString(), myStyle);
	}

}
