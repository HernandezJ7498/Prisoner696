﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testscript : MonoBehaviour {

	// Use this for initialization
    public int value1;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other){
         GameManager.instance.haskey = true;
        GameManager.instance.collect(gameObject);
    }
}
