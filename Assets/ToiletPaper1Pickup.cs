using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToiletPaper1Pickup : MonoBehaviour {

	// Use this for initialization
	public GameObject Loudspeaker;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(){
		Loudspeaker.GetComponent<Text> ().text = "Press X to pick up toilet paper";
		if(Input.GetKeyDown(KeyCode.X)){
			GameManager.instance.ToiletPaper1Pickup = true;
		}
	}
	void OnTriggerExit(){
		Loudspeaker.GetComponent<Text> ().text = "";
	}
	void OnDestroy(){
		GameManager.instance.BuschmannEventSequence += 1;
	}
}
