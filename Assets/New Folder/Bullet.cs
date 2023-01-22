using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 40;
    Enemy enemy;
    public float timer;
    public float waiting;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    void Update()
    {
        timer+=Time.deltaTime;
        if (timer > 2)
        {
            Destroy(gameObject);
        }
        
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
		enemy = hitInfo.GetComponent<Enemy>();
		if (enemy != null)
		{
			enemy.TakeDamage(damage);
			Destroy(gameObject);
		}
		
	}
    //asdfagfsfa
    
}
