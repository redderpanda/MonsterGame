using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Slider healthBar;
    public Text HPText;
    public PlayerHealthManager playerHealth;

    private PlayerStats PS;
    public Text levelText;
    public Text expText;

    private static bool UIExists;

	// Use this for initialization
	void Start () {

        if (!UIExists)
        {
            UIExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        PS = GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update() {
        int currentEXP = PS.currentEXP - PS.toLevelUp[PS.currentLevel - 1];
        int totalEXP = (PS.toLevelUp[PS.currentLevel] - PS.toLevelUp[PS.currentLevel - 1]);
        healthBar.maxValue = playerHealth.playerMaxHealth;
        healthBar.value = playerHealth.playerCurrentHealth;
        HPText.text = "HP: " + playerHealth.playerCurrentHealth + "/" + playerHealth.playerMaxHealth;
        levelText.text = "Level: " + PS.currentLevel;
        expText.text = "EXP: " + currentEXP + "/"  + totalEXP;
        //Debug.Log(PS.currentEXP / PS.toLevelUp[PS.currentLevel]); *says 0 constantly

    }
}
