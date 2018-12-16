using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastKeyPickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnTriggerEnter(){
		GameManager.instance.HasLastKey = true;
		Destroy (gameObject);
	}
}
