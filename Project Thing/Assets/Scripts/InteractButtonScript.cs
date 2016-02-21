using UnityEngine;
using System.Collections;

public class InteractButtonScript : MonoBehaviour {

	public Renderer rend;
	bool areEnabled = false;
	// Use this for initialization
	void Start () {
		
		rend.enabled = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (areEnabled == true) {
			rend.enabled = true;
		} else {
			rend.enabled = false;
		}
		
	}
	
	public void enableButtons( bool enB ){
		
		areEnabled = enB;
		Debug.Log ("Success");
		
		
	}
}
