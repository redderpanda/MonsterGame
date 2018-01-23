using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject currentTarget;
    private Vector3 targetPosition;
    public float moveSpeed;

    private static bool cameraExists;

	// Use this for initialization
	void Start () {

        if (!cameraExists)
        {
            cameraExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
	
	// Update is called once per frame
	void Update () {

        targetPosition = new Vector3(currentTarget.transform.position.x, currentTarget.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);

		
	}
}
