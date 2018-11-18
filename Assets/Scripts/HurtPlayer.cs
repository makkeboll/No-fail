﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour {

    public int DamageToGive;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Mobs")
        {
            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(DamageToGive);
        }
    }
  
        
    }


