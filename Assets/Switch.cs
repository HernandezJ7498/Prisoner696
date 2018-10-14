using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

	// Use this for initialization
	public int switchNumber;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(GameManager.instance.switches[switchNumber]);
	}
    void OnTriggerEnter(){
        GameManager.instance.switchon(switchNumber);
    }
}
