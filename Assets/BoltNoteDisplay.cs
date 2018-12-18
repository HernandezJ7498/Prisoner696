using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoltNoteDisplay : MonoBehaviour {

	// Use this for initialization
	public GameObject Drawer;
	public GameObject LoudSpeaker;
	public GameObject Note;
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(){
		Note.SetActive (true);
	}
	void OnTriggerExit(){
		gameObject.GetComponent<BoxCollider> ().enabled = false;
		Drawer.GetComponent<BoxCollider> ().enabled = true;
		Drawer.GetComponent<Animation> ().Play ("CloseBoltDrawer");
		Note.SetActive (false);
		LoudSpeaker.GetComponent<Text> ().text = "";
	}
}
