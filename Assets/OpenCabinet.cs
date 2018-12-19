using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenCabinet : MonoBehaviour {

	// Use this for initialization
	public GameObject Paper;
	public GameObject Loudspeaker;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(){
		if (GameManager.instance.BuschmannEventSequence == 2) {
			Loudspeaker.GetComponent<Text>().text = "Press X to open cabinet";
			if (Input.GetKeyDown (KeyCode.X)) {
				gameObject.GetComponent<Animation> ().Play ("OpenCabinetAnimation");
				StartCoroutine (enablepaper());
			}
		}
	}
	void OnTriggerExit(){
		Loudspeaker.GetComponent<Text> ().text = "";
	}
	IEnumerator enablepaper(){
		yield return new WaitForSeconds (5.00f);
		Paper.GetComponent<BoxCollider> ().enabled = true;
	}
}
