using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    Rigidbody2D rgb;
    Vector3 velocity;
    public float jumpAmount = 4.5f;
    public bool doubleJump;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && Mathf.Approximately(rgb.velocity.y, 0)){
            doubleJump = true;
            rgb.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);
            animator.SetBool("jump", true);
        }
        else if (Input.GetButtonDown("Jump") && doubleJump)
        {
            rgb.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);
            doubleJump = false;
        }
        if(animator.GetBool("jump") && Mathf.Approximately(rgb.velocity.y, 0f))
        {
            animator.SetBool("jump", false);
        }
    }
}
