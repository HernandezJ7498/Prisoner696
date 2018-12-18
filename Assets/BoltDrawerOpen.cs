using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoltDrawerOpen : MonoBehaviour {

	// Use this for initialization
	bool wasopened;
	public GameObject LoudSpeaker;
	public GameObject Note;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(){
		LoudSpeaker.GetComponent<Text>().text = "Press X to open drawer";
	}
	void OnTriggerStay(){
		if (!wasopened) {
			if(Input.GetKeyDown(KeyCode.X)){
				gameObject.GetComponent<Animation> ().Play ("OpenBoltDrawer");
				StartCoroutine (activatenote());
				gameObject.GetComponent<BoxCollider> ().enabled = false;
			}
		}
	}
	IEnumerator activatenote(){
		yield return new WaitForSeconds (3);
		Note.GetComponent<BoxCollider> ().enabled = true;
		LoudSpeaker.GetComponent<Text>().text = "";
	}
	void OnTriggerExit(){
		LoudSpeaker.GetComponent<Text>().text = "";
	}
}
