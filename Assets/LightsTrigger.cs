using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsTrigger : MonoBehaviour {

	// Use this for initialization
	public GameObject Lights;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(){
		Lights.SetActive (true);
	}
}
