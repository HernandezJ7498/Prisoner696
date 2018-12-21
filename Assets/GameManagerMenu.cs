using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerMenu : MonoBehaviour {

	// Use this for initialization
	public GameObject Prisoner;
	public GameObject SixNine;
	public GameObject Six;
	public GameObject buttontext;
	public GameObject ThePanel;
	public Sprite[] images = new Sprite[5]; 
	int randomnum;
	void Start () {
		Prisoner.GetComponent<Animation> ().Play ("PrisonerAnimate");
		SixNine.GetComponent<Animation> ().Play ("69Animate");
		Six.GetComponent<Animation> ().Play ("6Animate");
		randomnum = Random.Range (0, 4);
		ThePanel.GetComponent<Image>().sprite = images[randomnum];


	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void LoadGame(){
		SceneManager.LoadScene ("PreGameCredits");
	}
	public void quitgame(){
		Application.Quit ();
	}
}
