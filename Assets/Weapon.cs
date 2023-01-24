using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int max=3;
	int shooting=0;
    // Update is called once per frame
    void Update()
    {
		if (shooting < max)
		{
			if (Input.GetButtonDown("Fire1"))
			{
				Shoot();
				shooting++;
			}
		}
		

	}
	
	void Shoot()
    {
        Instantiate(bulletPrefab,firePoint.position,firePoint.rotation);
		
		
	}
}
