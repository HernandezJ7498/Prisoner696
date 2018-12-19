using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputerImages : MonoBehaviour {

	// Use this for initialization
	public GameObject WebsiteImage;
	public GameObject Refresh;
	public GameObject LoudSpeaker;
	public Sprite Wikipedia;
	public Sprite ElonImage;
	public Sprite Puzzlesolve;
	public Sprite Boredatworkmeme;
	public Sprite FarmSimulator;
	public bool ImageEnabled;
	float randomnum;
	void Start () {
		WebsiteImage.GetComponent<Image> ().sprite = Wikipedia;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(){
		GunManager.instance.DisableGuns ();
		LoudSpeaker.GetComponent<Text>().text = "Press X to access laptop";	
		if(Input.GetKeyDown(KeyCode.X)){	
			ImageEnabled = true;
			WebsiteImage.SetActive (true);
			Refresh.GetComponent<Text>().text = "Left click to refresh page";	
		}
		if(Input.GetKeyDown(KeyCode.Mouse0) && ImageEnabled){
			randomnum = Random.Range(0.0f,1.0f);
			Debug.Log (randomnum);
			if(randomnum >0.0f && randomnum <0.25f){
				WebsiteImage.GetComponent<Image> ().sprite = Wikipedia;
			}else if(randomnum >0.25f && randomnum <0.50f){
				WebsiteImage.GetComponent<Image> ().sprite = ElonImage;
			}
			else if(randomnum >0.50f && randomnum <0.70f){
				WebsiteImage.GetComponent<Image> ().sprite = Boredatworkmeme;
			}
			else if(randomnum >0.70f && randomnum <0.95){
				WebsiteImage.GetComponent<Image> ().sprite = FarmSimulator;
			}
			else{
				WebsiteImage.GetComponent<Image> ().sprite = Puzzlesolve;
			}

		}
	}
	void OnTriggerExit(){
		ImageEnabled = false;
		WebsiteImage.SetActive (false);
		LoudSpeaker.GetComponent<Text>().text = "";	
		Refresh.GetComponent<Text>().text = "";
	}
}
