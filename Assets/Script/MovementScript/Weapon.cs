using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float max=0;
    // Update is called once per frame
    void Update()
    {

			if (Input.GetButtonDown("Fire1"))
			{
				Shoot();
				
			}

	}
	
	void Shoot()
    {
        Instantiate(bulletPrefab,firePoint.position,firePoint.rotation);
		
		
	}
}
