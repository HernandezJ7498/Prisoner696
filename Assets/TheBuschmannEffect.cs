using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TheBuschmannEffect : MonoBehaviour {

	public GameObject Player;
	public GameObject LoudSpeaker;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(){
		Player.transform.position = new Vector3 (552.15f,384.68f,-22.9f);
		LoudSpeaker.GetComponent<Text>().text = "SIKE NIGGA YOU THOUGHT!";
		GameManager.instance.alreadydead = true;
		StartCoroutine (removetext());
	}
	IEnumerator removetext(){
		yield return new WaitForSeconds (10);
		LoudSpeaker.GetComponent<Text> ().text = "";
	}
}
