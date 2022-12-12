using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignChange : MonoBehaviour
{
    public GameObject MinigameSign, MinigameCompleteSign;

    void Update()
    {
        if (GameObject.Find("Marker1") == null)
	{
	    if (GameObject.Find("Marker2") == null)
	    {
		if (GameObject.Find("Marker3") == null)
		{
	    	    GameObject MiniComplete = Instantiate(MinigameCompleteSign);
	    	    MiniComplete.transform.position = MinigameSign.transform.position;
	    	    MiniComplete.transform.rotation = MinigameSign.transform.rotation;
	    	    Destroy(MinigameSign);
		}
	    }
	}
    }
}
