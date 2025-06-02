﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sidestep : MonoBehaviour
{
	
	public Transform Player;
	public Rigidbody rb;
	bool hasPressed = false; 
	int count = 0;
	
	private float lastLapTime = 0f; 
	private float threshold = 0.3f;
  
    // Update is called once per frame
    void Update()
    {
	    if(Input.GetKeyDown(KeyCode.A)){
	    	
	    	hasPressed = true;
	    	//count += 1;
	    	
	    	float CurrentTime = Time.time;
	    	
	    	if(CurrentTime - lastLapTime <= threshold){
	    	
		    rb.AddForce( 50f, 0 , 0, ForceMode.Impulse);
		    lastLapTime = 0f;
		    
		    }
		    else{
		    	
			    lastLapTime = 0f;
		    	
		    }
		       
		    	
	    	
	    }
    }
}
