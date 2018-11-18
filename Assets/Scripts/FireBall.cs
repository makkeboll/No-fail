using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{

   
    public float BallSpeed;

    private Rigidbody2D theRB;

    public GameObject FireBallEffect;




    // Use this for initialization
    void Start()
    {

        theRB = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(BallSpeed * transform.localScale.x, 0);

    }



   void OnTriggerEnter2D(Collider2D other)
    {


        Instantiate(FireBallEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
