using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
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
	turn.y += Input.GetAxis("Mouse Y") * sensitivity;
	transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }
}