using UnityEngine;
using System.Collections;

public class WithinDistanceScript : MonoBehaviour {

    public ClickObject script;
    public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject == player)
        {
            script.isWithinDistance(true);
        }
       
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject == player)
        {
            script.isWithinDistance(false);
        }

        Debug.Log("exit from trigger success");

    }
}
