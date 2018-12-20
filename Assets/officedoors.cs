using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class officedoors : MonoBehaviour {

	// Use this for initialization
	public bool isopen;
	public int mynum;
	public GameObject Loudspeaker;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(){
		if(!isopen){
			Loudspeaker.GetComponent<Text> ().text = "Press X to open door";
			if(Input.GetKeyDown(KeyCode.X)){
				gameObject.GetComponent<Animation> ().Play ("Office"+mynum+"dooropen");
				isopen = true;

			}
		}
		/*else{
			Loudspeaker.GetComponent<Text> ().text = "Press X to open door";
			if(Input.GetKeyDown(KeyCode.X)){
				gameObject.GetComponent<Animation> ().Play ("Office"+mynum+"dooropen");
				isopen = true;
			}

		}*/
	}
	void OnTriggerExit(){
		Loudspeaker.GetComponent<Text> ().text = "";
	}
}
