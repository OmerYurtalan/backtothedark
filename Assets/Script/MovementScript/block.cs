using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    Rigidbody2D rgb;
    public Animator animator;
    void Start()
    {
        rgb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            animator.SetFloat("tut",1);
        }
        if (Input.GetKeyUp(KeyCode.X))
        {
            animator.SetFloat("tut", 0);
        }
    }
}
