using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeItem : MonoBehaviour
{

	public GameObject GameObject;
    public int create = 0;
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Item"))
		{
			Destroy(GameObject);
			create = 1;
		}

	}
}
