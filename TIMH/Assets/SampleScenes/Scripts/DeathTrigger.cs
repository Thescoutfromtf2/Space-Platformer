using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter3D(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
