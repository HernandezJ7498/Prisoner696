using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenElevatorKeyRoom : MonoBehaviour {

	// Use this for initialization
	bool IsOpen;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.instance.ElevatorKeyRoomSwitches && !IsOpen) {
			gameObject.GetComponent<Animation> ().Play ("OpenElevatorKeyRoom");
			IsOpen = true;
		}
	}
}
