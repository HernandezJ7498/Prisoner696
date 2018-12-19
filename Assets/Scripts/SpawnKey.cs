using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKey : MonoBehaviour {

	// Use this for initialization
    public int value1;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerStay(Collider other){
		if(GameManager.instance.IsSwinggingWood){	
			GameManager.instance.HasSecretKey = true;
        	GameManager.instance.collect(gameObject);
		}
    }
}
