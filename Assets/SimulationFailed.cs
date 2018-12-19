using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimulationFailed : MonoBehaviour {

	// Use this for initialization
	public GameObject SimulationFailedText;
	public GameObject InitiatingShutdownText;
	public GameObject Timer;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(){
		GameManager.instance.EndGame = true;
		SimulationFailedText.SetActive (true);
		InitiatingShutdownText.SetActive (true);
		SimulationFailedText.GetComponent<Animation> ().Play("Simulation failed");
		InitiatingShutdownText.GetComponent<Animation> ().Play("initiating shutdown");
		Timer.GetComponent<Animation> ().Play("GameTimer");
	}
}
