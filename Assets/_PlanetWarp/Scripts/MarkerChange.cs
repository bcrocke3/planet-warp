using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerChange : MonoBehaviour
{
    public GameObject Player, Marker1, Marker2, Marker3, MarkerGreen;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Marker1")
	{
	    GameObject Marker1On = Instantiate(MarkerGreen);
	    Marker1On.transform.position = Marker1.transform.position;
	    Marker1On.transform.rotation = Marker1.transform.rotation;
	    Destroy(Marker1);
	}

        if (col.gameObject.name == "Marker2")
	{
	    GameObject Marker2On = Instantiate(MarkerGreen);
	    Marker2On.transform.position = Marker2.transform.position;
	    Marker2On.transform.rotation = Marker2.transform.rotation;
	    Destroy(Marker2);
	}

        if (col.gameObject.name == "Marker3")
	{
	    GameObject Marker3On = Instantiate(MarkerGreen);
	    Marker3On.transform.position = Marker3.transform.position;
	    Marker3On.transform.rotation = Marker3.transform.rotation;
	    Destroy(Marker3);
	}
    }
}
