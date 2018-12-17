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
	bool seen3once;
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
		if(GameManager.instance.BuschmannEventSequence == 3){
			voice = "Buschmann: Ahhhhh... thats what im talking about! Okay so here's the scoop, i don't know if youve seen it\n" +
				"already but theres a chest in the storage room downstairs. That chest contains a weapons strong enough to\n" +
				"break anything and open anything. The chest is locked with a special passcode that is needed to access the weapon\n" +
				"i dont know what the passcode is but i can tell you how to figure it out. I left my X-Ray goggles in one\n" +
				"of the lockers in the locker room. The goggles will allow you to see through walls... there are 4 numbers scattered\n" +
				"all over the facility, these numbers are all different colors and the order of the colors im going to give you\n" +
				"will give you the password. The order is Red, Blue, Pink, Green... The glasses will only work once you're close\n" +
				"enough to the wall with the number behind it. Now Leave! let me take care of my bussiness";
			CharacterLongTalks.GetComponent<Text> ().text = voice;
			GameManager.instance.ToiletPaper2Pickup = true;
			CabinetDoor.GetComponent<BoxCollider> ().enabled = true;

		}
		if(GameManager.instance.BuschmannEventSequence == 4){
			voice = "Buschmann: Tinkle, Tinkle, little pee\n" +
				"In the potty i will be\n" +
				"Poopy, Poopy stinky-O\n" +
				"In the potty i will go\n" +
				"[Left Click to ask for number color order]\n" +
				"[Right Click to ask for instructions]";
			CharacterLongTalks.GetComponent<Text> ().text = voice;
			if (Input.GetKeyDown (KeyCode.Mouse0)) {
				GameManager.instance.BuschmannEventSequence += 1;
			}else if(Input.GetKeyDown(KeyCode.Mouse1)){
				GameManager.instance.BuschmannEventSequence = 3;
			}
		}
		if(GameManager.instance.BuschmannEventSequence == 5){
			voice = "It's Red, Blue, Pink, Green you idiot!";
			CharacterLongTalks.GetComponent<Text> ().text = voice;
		}
	}
	void OnTriggerExit(){
		CharacterLongTalks.GetComponent<Text> ().text = "";
		if(GameManager.instance.BuschmannEventSequence == 3){
			GameManager.instance.BuschmannEventSequence += 1;
		}
		if(GameManager.instance.BuschmannEventSequence == 5){
			GameManager.instance.BuschmannEventSequence -= 1;
		}
	}
}
