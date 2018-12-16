using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBolt : MonoBehaviour {

	// Use this for initialization
	public GameObject Gate;
	public bool opened;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(){
		if (!opened) {
			Gate.GetComponent<Animation> ().Play ("GateMove");
			opened = true;
		}
	}
}
