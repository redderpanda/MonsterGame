using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public int currentLevel;
    public int currentEXP;

    public int[] toLevelUp;

    public int[] HPlevels;
    public int[] attackLevels;
    public int[] defenseLevels;

    public int currentHP;
    public int currentAttack;
    public int currentDefense;

    private PlayerHealthManager playerHealth;


	// Use this for initialization
	void Start () {
        currentHP = HPlevels[1];
        currentAttack = attackLevels[1];
        currentDefense = defenseLevels[1];

        playerHealth = FindObjectOfType<PlayerHealthManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if(currentEXP >= toLevelUp[currentLevel])
        {
            //currentLevel++;
            levelUp();
        }
	}

    public void AddExperience(int experienceGained)
    {

        currentEXP += experienceGained;        

    }

    public void levelUp()
    {
        currentLevel++;
        currentHP = HPlevels[currentLevel];
        playerHealth.playerMaxHealth = currentHP;
        playerHealth.setMaxHealth();
        //playerHealth.playerCurrentHealth += currentHP - HPlevels[currentLevel - 1]; //if you want to not fully give health back on level up
        currentAttack = attackLevels[currentLevel];
        currentDefense = defenseLevels[currentLevel];

    }
}
