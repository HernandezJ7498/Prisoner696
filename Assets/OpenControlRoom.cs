using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenControlRoom : MonoBehaviour {

	// Use this for initialization
    public GameObject SwitchAlert;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerStay(){
        SwitchAlert.GetComponent<Text> ().text = "Use Object To Open Door";
        if(Input.GetMouseButtonDown(0)){   
            if(GunManager.instance.Guns[(int)GunManager.Weapons.Crowbar].activeSelf){
                GameManager.instance.collect(gameObject);
                SwitchAlert.GetComponent<Text> ().text = "";
            }
            else{
                //SwitchAlert.GetComponent<Text> ().text = "Not Strong Enough";
            }
        }
    }
    void OnTriggerExit(){
        SwitchAlert.GetComponent<Text> ().text = "";
    }
}
