using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class temel : MonoBehaviour
{

	Rigidbody2D rgb;
	public Vector3 velocity;
	public Animator animator;
	public float speedAmount = 5f;
	public sliding slide;
	public atak atak;
	public float activeMoveSpeed;
	public float dashSpeed;
	public float dashLength = 0.5f, dashCoolDown = 1f;
	private float dashCounter;
	private float dashCoolCounter;
	jump jump;
	// Start is called before the first frame update
	void Start()
	{
		activeMoveSpeed = speedAmount;
		rgb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{

		Movement();
		direction();
		if (Input.GetKeyDown(KeyCode.LeftAlt))
		{
			if (dashCoolCounter <= 0 && dashCounter <= 0)
			{
				activeMoveSpeed -= dashSpeed;
				dashCounter = dashLength;
				activeMoveSpeed = activeMoveSpeed * (-1);
			}

		}
		if (dashCounter > 0)
		{
			dashCounter -= Time.deltaTime;
			if (dashCounter <= 0)
			{
				activeMoveSpeed = speedAmount;
				dashCoolCounter = dashCoolDown;
			}
		}
		if (dashCoolCounter > 0)
		{
			dashCoolCounter -= Time.deltaTime;
		}
	}
	public void direction()
	{
		if (Input.GetAxisRaw("Horizontal") == -1)
		{
			transform.rotation = Quaternion.Euler(0f, 180f, 0f);
		}
		else if (Input.GetAxisRaw("Horizontal") == 1)
		{
			transform.rotation = Quaternion.Euler(0f, 0f, 0f);
		}
	}
	public void Movement()
	{
		if (!this.slide.animator.GetBool("slide") && !this.atak.animator.GetCurrentAnimatorStateInfo(0).IsTag("atakani"))
		{
			velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
		}
		if (!this.animator.GetCurrentAnimatorStateInfo(0).IsTag("atakani"))
		{
			transform.position += velocity * Time.deltaTime * activeMoveSpeed;
		}
		else if (this.animator.GetCurrentAnimatorStateInfo(0).IsTag("atakani") && Mathf.Approximately(rgb.velocity.y, 0))
		{
			transform.position += velocity * 0;
		}
		else if (this.animator.GetCurrentAnimatorStateInfo(0).IsTag("atakani") && !Mathf.Approximately(rgb.velocity.y, 0))
		{
			transform.position += velocity * Time.deltaTime * activeMoveSpeed;
		}
		animator.SetFloat("speed", Mathf.Abs(Input.GetAxis("Horizontal")));
	}
}