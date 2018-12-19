using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnKey : MonoBehaviour {

	// Use this for initialization
    public int value1;
	public GameObject CharacterTalks;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerStay(Collider other){
		if(!GameManager.instance.WoodEnabled){
			CharacterTalks.GetComponent<Text> ().text = "James: Damn thats far... maybe i could use something to reach it";
		}
		if(GameManager.instance.IsSwinggingWood){	
			GameManager.instance.HasSecretKey = true;
        	GameManager.instance.collect(gameObject);
		}
    }
	void OnTriggerExit(){
		CharacterTalks.GetComponent<Text> ().text = "";
	}
}
