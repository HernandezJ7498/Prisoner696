using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElevatorFloor1 : MonoBehaviour {

	// Use this for initialization
	public GameObject player;
	void Start () {
		//GameObject player = GameObject.Find("FSController");
	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(){
		player.transform.position = new Vector3 (571.1f, 384.9f, -16.6f);
	}
}
