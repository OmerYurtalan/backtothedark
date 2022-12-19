using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sliding : MonoBehaviour
{
    Rigidbody2D rgb;
    public Animator animator;
    public bool slide;
    public float slideTimer = 0;
    [SerializeField]
    public float maxSliderTimer;

    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        kayma();
    }
    public void kayma()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            slideTimer = 0;
            slide = true;
            animator.SetBool("slide", true);
        }
        if (slide)
        {
            slideTimer += Time.deltaTime;
            if (slideTimer > maxSliderTimer)
            {
                slide = false;
                animator.SetBool("slide", false);
            }

        }

    }
}
