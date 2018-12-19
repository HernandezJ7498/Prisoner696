using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentCollapse : MonoBehaviour {

	// Use this for initialization
	public GameObject Key;
	public GameObject Vent;
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}
	public void OnTriggerStay(){
		if (Input.GetKeyDown (KeyCode.Mouse0) && GunManager.instance.isEnabled ((int)GunManager.Weapons.Crowbar) && !GameManager.instance.VentBroke) {
			Vent.GetComponent<Animation> ().Play ("VentFall");
			GameManager.instance.VentBroke = true;
			Key.SetActive (true);
		}
			
	}
}
