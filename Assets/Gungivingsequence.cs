using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gungivingsequence : MonoBehaviour {

	// Use this for initialization
	public GameObject CharacterTalks;
	string Voice;
	bool gunready;
	public GameObject Gun;
	public GameObject Battery;
	bool laststep;
	void Start () {
		gunready = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnTriggerEnter(){
		if(GameManager.instance.BeganGunSequence == false){
			Gun.SetActive (true);
			GameManager.instance.BeganGunSequence = true;
		}
		if (GameManager.instance.GunEventSequence == 0) {
			Voice = "Zack: Who's there?? Hey you! i can't believe there's someone else.\n " +
			"My name is Zachary Lee Tate the Third, i woke up in a room full of cells adn started wandering around.\n" +
			"At first i thought it was my buddy Mike Haring playing a prank on me, i hate that guy...but i soon came to realize\n" +
			"that maybe im just part of the half that didn't vanish after the snap... get it? Avengers?\n" +
			"okay... tough crowd. Maybe you can help me.. go to the control room upstairs, there should be a bottom drawer\n" +
			"in the filing cabinet with a gun, bring me the gun.";
			CharacterTalks.GetComponent<Text> ().text = Voice;
		} else if (GameManager.instance.GunEventSequence == 1) {
			Battery.SetActive (true);
			Voice = "Nice!, nice!, nice! you see that door to the left of the stairs? Thats the way out of here but the key\n" +
			"is nowhere to be found. I've looked all over this damn place and i cant find it. I once met someone in here who\n" +
			" mentioned the possibility of a spare being somewhere in the vent system, i don't know what happened to Buschmann\n" +
			"and i don't trust him but at this point i dont have a choice. I designed this gun to scan for the master key\n" +
			"to that door but with some tweeks i can have it scan for any keys that would open that door. The only thing\n" +
			" i need is a battery, try looking for it around control or where the large battery packs are upstairs";
			CharacterTalks.GetComponent<Text> ().text = Voice;
		} else if (GameManager.instance.GunEventSequence == 2) {
			Voice = "You are a gift from the Gods! This should be ready to go. Take the gun and press the trigger\n" +
			"to scan the area. The gun will tell you how far you are from the key. Remember that the gun scans from\n" +
			"where you are pointing so keep that in mind he said it would be in the vents so if you find it, try using\n" +
			"a tool or something to hit the vent maybe the key will be in there. Hurry! before he snaps again!";
			laststep = true;
			GameManager.instance.ScannerEnabled = true;
			CharacterTalks.GetComponent<Text> ().text = Voice;
		} else{
			Voice = "What in tarnation are you still doing here if you found the key? GO! Get the hell out of this hell hole\n" +
			"i'll be right behind you as soon as i figure out how to move these boxes. If you see Mike, tell him this was not cool";
			CharacterTalks.GetComponent<Text> ().text = Voice;
		}
	}
	public void OnTriggerExit(){
		CharacterTalks.GetComponent<Text> ().text = "";
		if(laststep){
			GameManager.instance.GunEventSequence += 1;
		}
	}

}
