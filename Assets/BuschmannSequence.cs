using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuschmannSequence : MonoBehaviour {

	// Use this for initialization
	public GameObject ToiletPaper1;
	public GameObject ToiletPaper2;
	string voice;
	public GameObject CharacterLongTalks;
	public GameObject CabinetDoor;
	bool RespondedYes;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(){
		if(GameManager.instance.BeganBathroomSequence == false){
			GameManager.instance.BeganGunSequence = true;
		}
		if(GameManager.instance.BuschmannEventSequence == 0){
			voice = "Buschmann: Hey! Hey you! I don't know who you are and quite honestly i dont care\n" +
				"but i need your help kid. I was trying to find a way out of this shit hole so i decided\n" +
				"to go through the bathroom pipes... Genius right?? well at least i thought it was until\n" +
				"i got stuck. you mind helping me out? [Left Click TO Help Buschman]";
			CharacterLongTalks.GetComponent<Text> ().text = voice;
			if (Input.GetKeyDown (KeyCode.Mouse0) && !RespondedYes) {
				GameManager.instance.BuschmannEventSequence += 1;
				RespondedYes = true;
			}
		}
		if(GameManager.instance.BuschmannEventSequence == 1){
			voice = "Buschmann: If you can get this done for me, ill help you out with with getting a pretty cool toy.\n" +
				"I dont need you to help me get out of here...I'm actually quite comfy down here. all i need is\n" +
				"some some toilet paper look around and see if you find any.";
			CharacterLongTalks.GetComponent<Text> ().text = voice;
			GameManager.instance.ToiletPaper1Pickup = true;
			ToiletPaper1.GetComponent<BoxCollider>().enabled = true;
		}
		if(GameManager.instance.BuschmannEventSequence == 2){
			voice = "Buschmann: EWWWWW! What is your problem?? Charmin?? What am i a caveman? get this garbage away from me\n" +
				"i won't tell you anything until you get me some quality toilet paper. shameful... look around the front\n " +
				"in the control room or one of the offices there has to be something else.";
			CharacterLongTalks.GetComponent<Text> ().text = voice;
			GameManager.instance.ToiletPaper2Pickup = true;
			CabinetDoor.GetComponent<BoxCollider> ().enabled = true;
		}
	}
	void OnTriggerExit(){
		CharacterLongTalks.GetComponent<Text> ().text = "";
	}
}
