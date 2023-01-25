using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootExploing : MonoBehaviour
{
    public GameObject[] knifes;
    takeItem Item;
	int i = 2;
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            

			Destroy(knifes[i]);
			i--;
		}
        if (Item.create == 1)
        {
			GameObject createKnifes =Instantiate(knifes[++i]) as GameObject;
		}
		
	}
}
