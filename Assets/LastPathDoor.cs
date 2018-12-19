using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastPathDoor : MonoBehaviour {

	// Use this for initialization
	public GameObject CharacterTalks;
	public GameObject thebox;
	bool isopen;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(){
		if (!GameManager.instance.HasLastKey) {
			CharacterTalks.GetComponent<Text> ().text = "James: This door seems really secured, if only i could find the key";
		} else {
			if (!isopen) {
				gameObject.GetComponent<Animation> ().Play ("Openlastpath");
				isopen = true;
				StartCoroutine (waittoopen());
			}
		}
	}
	void OnTriggerExit(){
		CharacterTalks.GetComponent<Text> ().text = "";
	}
	IEnumerator waittoopen(){
		yield return new WaitForSeconds (7);
		GameManager.instance.HasLastKey = false;
		thebox.SetActive (false);
		gameObject.GetComponent<BoxCollider> ().enabled = false;
	}
}
