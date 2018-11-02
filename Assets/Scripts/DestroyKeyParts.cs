using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyKeyParts : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other){
        GameManager.instance.KeyParts += 1;
        GameManager.instance.collect(gameObject);
	}
}