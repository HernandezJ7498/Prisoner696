using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildScript : MonoBehaviour {

	// Use this for initialization
    public GameObject SwitchAlert;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerStay(){
        if (GameManager.instance.KeyParts == 3 && !GameManager.instance.HasAllKeys) {
			SwitchAlert.GetComponent<Text> ().text = "Press r to repair key";
            if (Input.GetKeyDown ("r")) {
                    GameManager.instance.HasAllKeys = true;
               // Debug.Log("Repaired");
				//SwitchAlert.GetComponent<Text> ().text = "Panel Must be active";
			}
		}
        if(GameManager.instance.KeyParts == 3 && GameManager.instance.HasAllKeys){
            SwitchAlert.GetComponent<Text> ().text = "Key Has Been Repaired";
        }
        if(GameManager.instance.KeyParts != 3){
            SwitchAlert.GetComponent<Text> ().text = "Acquire all key parts";
        }
    }
    void OnTriggerExit(){
        SwitchAlert.GetComponent<Text> ().text = "";
    }
}
