using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2dcollider : MonoBehaviour {

	// Use this for initialization
    //public GameObject SwitchAlert;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D()
    {

        Debug.Log("Inside Trigger");
    }
    void OnTriggerExit2D()
    {
        Debug.Log("Outside Trigger");
    }
}
