using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableNumber : MonoBehaviour {

	// Use this for initialization\
	public GameObject Number;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!GameManager.instance.GlassesOn) {
			Number.SetActive(false);
		}
		
	}
	void OnTriggerStay(){
		if(GameManager.instance.GlassesOn){
			Number.SetActive(true);
		}
	}
	void OnTriggerExit(){
		Number.SetActive(false);
	}
}
