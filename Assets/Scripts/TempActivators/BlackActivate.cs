using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackActivate : MonoBehaviour {

	// Use this for initialization
	public GameObject monster;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(){
		if (monster != null) {
			if (!monster.activeSelf) {
				monster.SetActive (true);
			}
		}
	}
}
