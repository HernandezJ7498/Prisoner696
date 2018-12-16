using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenControlRoom : MonoBehaviour {

	// Use this for initialization
    public GameObject SwitchAlert;
	bool IsOpened;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerStay(){
		if(!IsOpened){
			SwitchAlert.GetComponent<Text> ().text = "James: This door is locked... maybe a tool would help";
	        if(Input.GetMouseButtonDown(0)){   
		            if(GunManager.instance.Guns[(int)GunManager.Weapons.Crowbar].activeSelf){
						gameObject.GetComponent<Animation> ().Play ("OpenControlRoomDoor");
						IsOpened = true;
		                SwitchAlert.GetComponent<Text> ().text = "";
		            }
		            else{
		                //SwitchAlert.GetComponent<Text> ().text = "Not Strong Enough";
		            }
	        	}
	    	}
	}
    void OnTriggerExit(){
        SwitchAlert.GetComponent<Text> ().text = "";
    }
}
