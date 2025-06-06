using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	
	public float DamageThershold = 40f; 
	public GameObject Enemy; 
	public float level1ZombieAttack = 20f;
	public float level1SkeletonAttack = 25f;
	
    
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	    
    }
    
	// OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider.
	protected void OnCollisionEnter(Collision other)
	{
		DamageThershold -= level1ZombieAttack; 
	}
	
	void OnCollisionEnter(Collision other){
		
		
		DamageThershold -= level1SkeletonAttack; 
		
	}
}
