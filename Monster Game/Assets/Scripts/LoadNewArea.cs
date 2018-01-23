using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewArea : MonoBehaviour {

    public string levelToLoad;

    public string exitPoint;

    private PlayerController thePlayer;
	// Use this for initialization
	void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D( Collider2D objects)
    {
        if(objects.gameObject.name == "Player")
        {
            SceneManager.LoadScene(levelToLoad);
            // Application.LoadLevel(levelToLoad);
            thePlayer.startPoint = exitPoint;
        }

    }
}
