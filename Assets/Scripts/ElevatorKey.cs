using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorKey : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other){
		GameManager.instance.HasElevatorKey = true;
		GameManager.instance.collect(gameObject);
	}
}