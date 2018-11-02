using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyLock : MonoBehaviour {

	// Use this for initialization
    public GameObject SwitchAlert;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerStay(){
        SwitchAlert.GetComponent<Text> ().text = "Lock May Require Some manual force";
        if(Input.GetMouseButtonDown(0)){   
            GameManager.instance.collect(gameObject);
            GameManager.instance.Locks -= 1;
            SwitchAlert.GetComponent<Text> ().text = "";
        }
    }
    void OnTriggerExit(){
        SwitchAlert.GetComponent<Text> ().text = "";
    }
}
