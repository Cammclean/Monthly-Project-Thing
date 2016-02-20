using UnityEngine;
using System.Collections;

public class EnterAreaScript : MonoBehaviour {
    public GameObject player;
    public int level;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject == player)
        {
            Application.LoadLevel(level);
        }

    }
}
