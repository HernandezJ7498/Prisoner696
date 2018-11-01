using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSniperRoom : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(GameManager.instance.OpenSniperRoom == true){
			GameManager.instance.collect(gameObject);
		}
	}
}
