using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroydoor : MonoBehaviour {

	// Use this for initialization
    public int value1;
    public GameObject SwitchAlert;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//SwitchAlert.GetComponent<Text>().text = "";
	}
    void OnTriggerEnter(){
		if(GameManager.instance.HasSecretKey){
            GameManager.instance.collect(gameObject);
        }
        else{
            SwitchAlert.GetComponent<Text>().text = "Need Key";
        }
    }
    void OnTriggerExit(){
        SwitchAlert.GetComponent<Text>().text = "";
    }
}
