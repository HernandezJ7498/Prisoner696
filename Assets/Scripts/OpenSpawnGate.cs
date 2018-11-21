using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenSpawnGate : MonoBehaviour {

	// Use this for initialization
    public int value1;
    public GameObject SwitchAlert;
	bool IsOpen;
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		//SwitchAlert.GetComponent<Text>().text = "";
	}
    void OnTriggerEnter(){
		if(GameManager.instance.HasSecretKey && !IsOpen){
			gameObject.GetComponent<Animation> ().Play ("OpenSpawnGate");
			StartCoroutine (waitforanim());
			//gameObject.GetComponent<MeshCollider> ().enabled = false;
			IsOpen = true;
        }
        else{
			if (!IsOpen) {
				SwitchAlert.GetComponent<Text> ().text = "Need Key";
			}
        }
    }
    void OnTriggerExit(){
        SwitchAlert.GetComponent<Text>().text = "";
    }
	IEnumerator waitforanim(){
		yield return new WaitForSeconds (6);
		gameObject.GetComponent<MeshCollider> ().enabled = false;
	}
}
