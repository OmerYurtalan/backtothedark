using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engel : MonoBehaviour
{
    public LadderMovement info;
    public float timer=0f;
    public float maxTime=0.5f;
   
    void Start()
    {
        GetComponent<Collider2D>().enabled = false;
    }
    
    public void FixedUpdate()
    {
        if (!info.isClimbing)
        {

            GetComponent<Collider2D>().enabled = false;
        }
        else
        {
            GetComponent<Collider2D>().enabled = true;

        }
    }
    
        
    
}
