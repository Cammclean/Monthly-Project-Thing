using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

   
    public float speed = 2.0f;
	public Rigidbody2D r;
	float moveHorizontal;  
	float moveVertical;
    public CameraSmoothFollow cameraScript;
    public Transform targetRight;
    public Transform targetLeft;

	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {
		moveHorizontal = Input.GetAxisRaw("Horizontal");
		moveVertical = Input.GetAxisRaw("Vertical");
        if(moveHorizontal > 0)
        {
            cameraScript.changeTarget(targetRight);
        }
        else if(moveHorizontal < 0)
        {
            cameraScript.changeTarget(targetLeft);
        }

		Vector2 Movement = new Vector2(moveHorizontal, moveVertical/2.0f);

		r.velocity = Movement * speed;

}
}

