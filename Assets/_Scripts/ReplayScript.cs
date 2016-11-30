using UnityEngine;
using System.Collections;

public class ReplayScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)){
			Application.LoadLevel ("FungusNarr");
		}

		if (Input.GetKeyDown (KeyCode.Q)){
			Application.Quit ();
		}
	}
}
