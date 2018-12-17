using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToiletPaper2Pickup : MonoBehaviour {

	// Use this for initialization
	public GameObject LoudSpeaker;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(){
		LoudSpeaker.GetComponent<Text>().text = "Press X to Pick up toilet paper";
		if(Input.GetKeyDown(KeyCode.X)){
			Destroy (gameObject);
		}
	}
	void OnTriggerExit(){
		LoudSpeaker.GetComponent<Text> ().text = "";
	}
	void OnDestroy(){
		GameManager.instance.BuschmannEventSequence += 1;
		LoudSpeaker.GetComponent<Text> ().text = "";
	}

}
