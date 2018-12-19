using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastNoteDisplay : MonoBehaviour {

	// Use this for initialization
	public Sprite Note;
	public GameObject NoteDisplay;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(){
		NoteDisplay.SetActive (true);
		NoteDisplay.GetComponent<Image>().sprite = Note;
	}
	void OnTriggerExit(){
		NoteDisplay.SetActive (false);
	}
}
