using System.Collections;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {


    public int PlayerMaxHealth;
    public int PlayerCurrentHealth;


	// Use this for initialization
	void Start () {
        PlayerCurrentHealth = PlayerMaxHealth;

	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerCurrentHealth < 0)
        {
            gameObject.SetActive(false);

        }
	}

    public void HurtPlayer(int DamageToGive)

    {
        PlayerCurrentHealth -= DamageToGive;

    }

    public void SetMaxHealth()
    {
        PlayerCurrentHealth = PlayerMaxHealth;


    }



}


