using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {
    public int enemyMaxHealth;
    public int enemyCurrentHealth;

    private PlayerStats thePlayerStats;

    public int expToGive;

    // Use this for initialization
    void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
        thePlayerStats = FindObjectOfType<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyCurrentHealth <= 0)
        {
            Destroy(gameObject);
            thePlayerStats.AddExperience(expToGive);

        }
    }

    public void HurtEnemy   (int damage)
    {
        enemyCurrentHealth -= damage;

    }

    public void setMaxHealth()
    {
        enemyCurrentHealth = enemyMaxHealth;
    }

}
