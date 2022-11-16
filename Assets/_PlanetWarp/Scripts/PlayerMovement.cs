using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Vector2 turn;
    public float sensitivity = 0.5f;
    public float jumpAmount = 2;
    public float speed = 0.025f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
	rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w")){
	   transform.Translate(0,0,speed);
	  }
        if(Input.GetKey("s")){
	   transform.Translate(0,0,-speed);
	  }
        if (Input.GetKeyDown(KeyCode.Space)){
	    rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
	  }
        if(Input.GetKey("a")){
	   transform.Translate(-speed,0,0);
	  }
        if(Input.GetKey("d")){
	   transform.Translate(speed,0,0);
	  }
	
	turn.x += Input.GetAxis("Mouse X") * sensitivity;
	turn.y += Input.GetAxis("Mouse Y") * sensitivity;
	transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }
}