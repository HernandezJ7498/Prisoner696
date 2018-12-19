using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class woodpickup : MonoBehaviour {

	// Use this for initialization
	public GameObject LoudSpeaker;
	public GameObject MenuOption;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(){
		LoudSpeaker.GetComponent<Text> ().text = "Press X to pick up stick";
		if (Input.GetKeyDown (KeyCode.X)) {
			if (!GunManager.instance.isEnabled ((int)GunManager.Weapons.Wood))
				GunManager.instance.DisableGuns ();
				GunManager.instance.EnableGun ((int)GunManager.Weapons.Wood);
				GameManager.instance.WoodEnabled = true;
				MenuOption.SetActive (true);
				LoudSpeaker.GetComponent<Text> ().text = "";
				Destroy (gameObject);	
		}
	}
	void OnTriggerExit(){
		LoudSpeaker.GetComponent<Text> ().text = "";
	}
}
