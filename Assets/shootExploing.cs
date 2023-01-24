using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootExploing : MonoBehaviour
{
    public GameObject[] knifes;

    int i = 2;
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            Destroy(knifes[i]);
			i--;
		}
        
    }
}
