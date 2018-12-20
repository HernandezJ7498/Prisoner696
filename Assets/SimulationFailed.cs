using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SimulationFailed : MonoBehaviour {

	// Use this for initialization
	public GameObject SimulationFailedText;
	public GameObject InitiatingShutdownText;
	public GameObject Timer;
	public GameObject Player;
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
		StartCoroutine (waituntilend());
	}
	IEnumerator waituntilend(){
		yield return new WaitForSeconds (9);
		Player.transform.position = new Vector3 (521.9f,390.7f,-55.7f);
		SimulationFailedText.SetActive (true);
		InitiatingShutdownText.SetActive (false);
		Timer.SetActive (false);
		SimulationFailedText.GetComponent<Text> ().color = Color.white;
		SimulationFailedText.GetComponent<Text>().text = "Restarting Simulation";
		StartCoroutine (tobecontinued());
	}
	IEnumerator tobecontinued(){
		yield return new WaitForSeconds (15);
		SceneManager.LoadScene ("ToBeContinued");
	}
}
