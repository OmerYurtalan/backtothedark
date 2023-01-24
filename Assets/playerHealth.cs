using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Animator animator;
    public HealthBar healthBar;
    bool isDead;

    void Start()
    {
        isDead = false;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    void Update()
    {
        if (!isDead)
        {
			checkhealth();
		}
        
        
    }
    public void checkhealth()
    {
		if (Input.GetKeyUp(KeyCode.O))
		{
			TakeDamage(20);
		}
	}

    // Update is called once per frame
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        animator.SetTrigger("Hurt");
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        animator.SetBool("IsDead", true);
		GetComponent<temel>().enabled = false;
        GetComponent<jump>().enabled = false;
		GetComponent<atak>().enabled = false;
        GetComponent<Weapon>().enabled = false;
        isDead = true;
	}
}
