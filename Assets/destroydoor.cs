using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroydoor : MonoBehaviour {

	// Use this for initialization
    public int value1;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other){
        if(GameManager.instance.haskey)
            GameManager.instance.collect(gameObject);
    }
}
