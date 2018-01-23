using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {
    public int playerMaxHealth;
    public int playerCurrentHealth;

    private bool flashing;
    public float flashLength;
    public float flashCounter;

    private SpriteRenderer playerSprite;

	// Use this for initialization
	void Start () {
        playerCurrentHealth = playerMaxHealth;

        playerSprite = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if(playerCurrentHealth <= 0)
        {
            gameObject.SetActive(false);


        }
        if(flashing)
        {
            if (flashCounter > flashLength * .66f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
            }
            else if (flashCounter > flashLength * .33f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
            }
            else if (flashCounter > 0f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
            }
            else
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
                flashing = false;
            }
            flashCounter -= Time.deltaTime;
        }

	}

   public void HurtPlayer(int damage)
    {
        playerCurrentHealth -= damage;
        flashing = true;
        flashCounter = flashLength;

    }

    public void setMaxHealth()
    {
        playerCurrentHealth = playerMaxHealth;
    }
}
