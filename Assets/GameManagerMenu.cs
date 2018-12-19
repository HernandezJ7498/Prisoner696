using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerMenu : MonoBehaviour {

	// Use this for initialization
	public GameObject Prisoner;
	public GameObject SixNine;
	public GameObject Six;
	public GameObject buttontext;
	void Start () {
		Prisoner.GetComponent<Animation> ().Play ("PrisonerAnimate");
		SixNine.GetComponent<Animation> ().Play ("69Animate");
		Six.GetComponent<Animation> ().Play ("6Animate");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void LoadGame(){
		SceneManager.LoadScene ("PreGameCredits");
	}
}
