using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sidestep : MonoBehaviour
{
	
	public Transform Player;
	public Rigidbody rb;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	    if(Input.GetKeyDown(KeyCode.RightArrow)){
	    	
		    if(Input.GetKeyDown(KeyCode.RightArrow)){
		    	
		    	rb.AddForce( 50f, 0 , 0);
		       
		    }	
	    	
	    }
    }
}
