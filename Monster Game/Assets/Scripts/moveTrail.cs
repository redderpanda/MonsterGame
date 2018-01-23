using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTrail : MonoBehaviour {

    public int moveSpeed = 10;
    	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        //Destroy(gameObject, 5f); if used lose transform
	}
}
