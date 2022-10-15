using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public GameObject sun;
    public int speed;
    private Vector3 axis = Vector3.up;
    void Update()
    {
        transform.RotateAround(sun.transform.position, axis, speed * Time.deltaTime);
    }

}
