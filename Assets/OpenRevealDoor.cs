using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenRevealDoor : MonoBehaviour {

	// Use this for initialization
	bool doonce;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(GameManager.instance.Locks == 0 && !doonce){
			gameObject.GetComponent<Animation> ().Play ("OpenRevealDoor");
			doonce = true;
		}
	}
}
