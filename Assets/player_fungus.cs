using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus ;

public class player_fungus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
    	if(collision.gameObject.tag == "hint1")
    	{
        	Flowchart.BroadcastFungusMessage("hint1");
    	}

    	if(collision.gameObject.tag == "hint2")
    	{
        	Flowchart.BroadcastFungusMessage("hint2");
    	}

    	if(collision.gameObject.tag == "hint3")
    	{
        	Flowchart.BroadcastFungusMessage("hint3");
    	}

    	if(collision.gameObject.tag == "hint4")
    	{
        	Flowchart.BroadcastFungusMessage("hint4");
    	}
    }
}

