using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenLastPath : MonoBehaviour {

	// Use this for initialization
    public GameObject SwitchAlert;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerStay(){
        if(!GameManager.instance.HasAllKeys){
            SwitchAlert.GetComponent<Text> ().text = "KeyRequired";
        }
        else{
            GameManager.instance.collect(gameObject);
        }
    }
    void OnTriggerExit(){
        SwitchAlert.GetComponent<Text> ().text = "";
    }
}
