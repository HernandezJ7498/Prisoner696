using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class WordsBlink : MonoBehaviour {

	// Use this for initialization
	public GameObject quote;
	public GameObject buttontext;
	void Start () {
		quote.GetComponent<Animation> ().Play ("quote");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void nextscene(){
		buttontext.GetComponent<Text>().text = "Loading...";
		SceneManager.LoadScene ("MainScene");
	}
}
