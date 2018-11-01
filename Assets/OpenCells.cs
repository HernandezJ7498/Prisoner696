using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCells : MonoBehaviour {

	// Use this for initialization
	public GameObject RGate3;
	public GameObject RGate1;
	public GameObject LGate1;
	public GameObject LGate2;
	public GameObject LGate3;

	bool onetimeactive = false;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(){
		if (!onetimeactive) {
			RGate3.GetComponent<Animation> ().Play ("RGate3Move");
			RGate1.GetComponent<Animation> ().Play ("RGate1Move");
			LGate1.GetComponent<Animation> ().Play ("LGate1Move");
			LGate2.GetComponent<Animation> ().Play ("LGate2Move");
			LGate3.GetComponent<Animation> ().Play ("LGate3Move");
			onetimeactive = true;
		}
	}
}
