using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrowbarPickup : MonoBehaviour {

	// Use this for initialization
    public GameObject SwitchAlert;
	public GameObject BuschmannSequence;
	public GameObject MenuOption;
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerStay(){
		SwitchAlert.GetComponent<Text>().text = "Press X to pick up crowbar";
        if (Input.GetKeyDown("x")) {
			GunManager.instance.DisableGuns ();
			int thegun = (int)GunManager.Weapons.Crowbar;
			GameManager.instance.CrowbarEnabled = true;
			GunManager.instance.DisableGuns ();
			GunManager.instance.EnableGun (thegun);
			GameManager.instance.BeganBathroomSequence = true;
			MenuOption.SetActive (true);
			SwitchAlert.GetComponent<Text>().text = "";
			BuschmannSequence.SetActive (true);
			GameManager.instance.Dot.SetActive (false);
			Destroy (gameObject);
		}
	}
    void OnTriggerExit(){
        SwitchAlert.GetComponent<Text>().text = "";
    }
}
