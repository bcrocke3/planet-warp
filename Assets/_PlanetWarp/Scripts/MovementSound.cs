using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSound : MonoBehaviour
{
    public AudioSource Footsteps;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)){
            if (Input.GetKey(KeyCode.Space))
            {
                Footsteps.enabled = false;
            }
            else
            {
                Footsteps.enabled = true;
            }
        }
        else
        {
            Footsteps.enabled = false;
        }
    }
}
