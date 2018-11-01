using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Elevator : MonoBehaviour {

	// Use this for initialization
	public GameObject player;
	public GameObject SwitchAlert;
	void Start () {
		//GameObject player = GameObject.Find("FSController");
	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(){
		if (GameManager.instance.HasElevatorKey) {
			player.transform.position = new Vector3 (567.1f, 374.7f, -10.6f);
		} else {
			SwitchAlert.GetComponent<Text>().text = "Need Key to start elevator";
		}
	}void OnTriggerExit(){
		SwitchAlert.GetComponent<Text>().text = "";
	}
}
