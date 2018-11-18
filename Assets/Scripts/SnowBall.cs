using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall : MonoBehaviour
{


    public float BallSpeed;

    private Rigidbody2D theRB;

    public GameObject SnowBallEffect;




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



    void OnTriggerEnter2D(Collider2D Other)
    {
        Instantiate(SnowBallEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
