using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atak : MonoBehaviour
{
    Rigidbody rgb;
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int attackDamage = 40;
    public float attackRate = 2f;
    float nextAttackTime = 0f;
    temel temel;
  
    void Start()
    {
        rgb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
            Atak();
        
        

	}
    public void Atak()
    {
		
		if (Input.GetKeyDown(KeyCode.C) && !this.animator.GetCurrentAnimatorStateInfo(0).IsTag("atakani"))
        {
            
			attack();
            nextAttackTime = Time.time+1f/attackRate;
            temel.velocity = Vector3.zero;
		}
		
	}
    void attack()
    {
        animator.SetTrigger("atakani");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position,attackRange,enemyLayers);
        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }
    }
    private void OnDrawGizmosSelected()
    {
        if(attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position,attackRange);
    }
}
