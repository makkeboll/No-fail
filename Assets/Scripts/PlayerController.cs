using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    public float moveSpeed;
    public float jumpForce;

    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;
    public KeyCode throwBall;
    public KeyCode throwFire;
    public KeyCode ThrowHeal;

    private Rigidbody2D theRB;

    public Transform GroundCheckPoint;
    public float GroundCheckRadius;
    public LayerMask WhatIsGround;



    public bool isGrounded;

    private Animator Anim;
    public GameObject SnowBall;
    public GameObject FireBall;
    public GameObject HealBall;
    public Transform ThrowPoint;





    // Use this for initialization
    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();

        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics2D.OverlapCircle(GroundCheckPoint.position, GroundCheckRadius, WhatIsGround);

        if (Input.GetKey(left))
        {
            theRB.velocity = new Vector2(-moveSpeed, theRB.velocity.y);

        }
        else if (Input.GetKey(right))
        {
            theRB.velocity = new Vector2(moveSpeed, theRB.velocity.y);
        }
        else
        {
            theRB.velocity = new Vector2(0, theRB.velocity.y);
        }

        if (Input.GetKeyDown(jump) && isGrounded)
        {
            theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
        }
        if (Input.GetKeyDown(throwBall))
        {
           GameObject BallClone = (GameObject) Instantiate(SnowBall, ThrowPoint.position, ThrowPoint.rotation);
            BallClone.transform.localScale = transform.localScale;
            Anim.SetTrigger("Throw");

        }
        if (Input.GetKeyDown(throwFire))
        {
            GameObject BallClone = (GameObject)Instantiate(FireBall, ThrowPoint.position, ThrowPoint.rotation);
            BallClone.transform.localScale = transform.localScale;
            Anim.SetTrigger("Throw");

        }
        if (Input.GetKeyDown(ThrowHeal))
        {
            GameObject BallClone = (GameObject)Instantiate(HealBall, ThrowPoint.position, ThrowPoint.rotation);
            BallClone.transform.localScale = transform.localScale;
            Anim.SetTrigger("Throw");

        }

        if (theRB.velocity.x < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else if (theRB.velocity.x > 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }

            Anim.SetFloat("Speed", Mathf.Abs(theRB.velocity.x));
            Anim.SetBool("Grounded", isGrounded);

        
        {
               
                }

        }

        }




