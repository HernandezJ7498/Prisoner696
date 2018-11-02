using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUnicorn : MonoBehaviour {

	// Use this for initialization
	public GameObject Unicorn;
	GameObject UnicornGuard;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerExit(){
			UnicornGuard = Instantiate (Unicorn, transform.position, transform.rotation);
	}
}
