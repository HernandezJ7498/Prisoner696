using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class door : MonoBehaviour {
	GameObject thedoor;
	public GameObject SwitchAlert;

void OnTriggerEnter ( Collider obj  ){
		if (GameManager.instance.ElevatorPower) {
			thedoor = GameObject.FindWithTag ("SF_Door");
			thedoor.GetComponent<Animation> ().Play ("open");
		} else{
			SwitchAlert.GetComponent<Text> ().text = "Elevator Power must be on";
		}
}

void OnTriggerExit ( Collider obj  ){
		if (GameManager.instance.ElevatorPower) {
			thedoor = GameObject.FindWithTag ("SF_Door");
			thedoor.GetComponent<Animation> ().Play ("close");
		} else {
			SwitchAlert.GetComponent<Text> ().text = "";
		}
}
}