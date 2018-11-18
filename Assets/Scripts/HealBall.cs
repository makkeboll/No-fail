using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealBall : MonoBehaviour
{


    public float BallSpeed;

    private Rigidbody2D theRB;

    public GameObject HealBallEffect;




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
        Instantiate(HealBallEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}