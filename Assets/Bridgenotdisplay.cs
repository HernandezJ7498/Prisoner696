using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridgenotdisplay : MonoBehaviour {

	// Use this for initialization
	public GameObject Note;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnTriggerStay(){
		if (!GameManager.instance.BridgeIsActive) {
			Note.SetActive(true);
		}
	}
	public void OnTriggerExit(){
		if (Note.activeSelf) {
			Note.SetActive(false);
		}
	}
}
