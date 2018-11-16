using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OpenCells : MonoBehaviour {

	// Use this for initialization
	public GameObject RGate3;
	public GameObject RGate1;
	public GameObject LGate1;
	public GameObject LGate2;
	public GameObject LGate3;
	public GameObject SwitchAlert;
	bool onetimeactive = false;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerStay(){
		if (!GameManager.instance.PanelActive) {
			if (Input.GetKeyDown ("x")) {
				StartCoroutine (wait ());
				SwitchAlert.GetComponent<Text> ().text = "Panel Must be active";
			}
		}
		if (GameManager.instance.PanelActive && !onetimeactive) {
			if (Input.GetKeyDown ("x")) {
				RGate3.GetComponent<Animation> ().Play ("RGate3Move");
				RGate1.GetComponent<Animation> ().Play ("RGate1Move");
				LGate1.GetComponent<Animation> ().Play ("LGate1Move");
				LGate2.GetComponent<Animation> ().Play ("LGate2Move");
				LGate3.GetComponent<Animation> ().Play ("LGate3Move");
				onetimeactive = true;
			}
		}
	}
	void OnTriggerExit(){
		SwitchAlert.GetComponent<Text> ().text = "";
	}
	void OnTriggerEnter(){
		if (!onetimeactive) {
			SwitchAlert.GetComponent<Text> ().text = "Press X to open all cells";
		} else {
				SwitchAlert.GetComponent<Text> ().text = "Cells are open";
		}
	}
	IEnumerator wait(){
		yield return new WaitForSeconds (18);
	} 
}
