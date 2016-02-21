using UnityEngine;
using System.Collections;

public class ClickObject : MonoBehaviour {

    
    
    bool display = false;
    bool enable = true;
	float xPosition;
	float yPosition;
	public GameObject obj;
	public InspectButtonScript script;
	public InteractButtonScript script2;



	// Use this for initialization
	void Start () {
		xPosition = obj.transform.position.x;
		yPosition = obj.transform.position.y;
		if ( script == null ) {
			Debug.Log("script reference is null: please assign in Inspector");
		}
		
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void OnMouseDown()
    {

		display = true;
		script.enableButtons (true);
		script2.enableButtons (true);
		Debug.Log ("You clicked it");


    }
    void OnMouseExit()
    {

        display = false;
		script.enableButtons (false);
		script2.enableButtons (false);

    }

    void OnGUI()
    {
        if (display == true)
        {
            if (GUI.Button(new Rect(xPosition, yPosition, 150, 45), "Inspect"))
                print("You clicked the button!");
                
        }
        else
        {
            display = false;
        }
    }
}
