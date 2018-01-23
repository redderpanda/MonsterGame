using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour {

    public int damageToGive;
    public GameObject damageParticles;
    public Transform HitPoint;
    public GameObject damageNumber;
    private int currentDamage;


    private PlayerStats PS;

	// Use this for initialization
	void Start () {
        PS = FindObjectOfType<PlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            currentDamage = damageToGive + PS.currentAttack;
            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(currentDamage);
            Instantiate(damageParticles, HitPoint.position, HitPoint.rotation);
            var clone = (GameObject) Instantiate(damageNumber, HitPoint.position, Quaternion.Euler(Vector3.zero));
            clone.GetComponent<FloatingNumbers>().damageNumber = currentDamage;
        }
    }
}
