using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBlink : MonoBehaviour {

	// Use this for initialization
	public GameObject redlight;
	void Start () {
		StartCoroutine (Blink());
	}
	
	// Update is called once per frame
	void Update () {
	}
	IEnumerator Blink(){
		while(true){	
			yield return new WaitForSeconds (1.5f);
			redlight.GetComponent<Light> ().enabled = !redlight.GetComponent<Light> ().enabled;
		}
	}

}
