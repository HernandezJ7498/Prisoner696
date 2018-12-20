using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishGame : MonoBehaviour {

	// Use this for initialization
	public GameObject ToBeContinued;
	void Start () {
		ToBeContinued.GetComponent<Animation> ().Play ("ToBeContinued");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator endgame(){
		yield return new WaitForSeconds (7);
		Application.Quit();
	}
}
