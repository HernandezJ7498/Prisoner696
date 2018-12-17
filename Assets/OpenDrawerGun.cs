using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDrawerGun : MonoBehaviour {

	// Use this for initialization
	bool isopen;
	bool gunpickedup;
	bool done;
	public GameObject LoudSpeaker;
	public GameObject Gun;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnTriggerStay(){
		if (!isopen && GameManager.instance.BeganGunSequence == true && !done) {
			LoudSpeaker.GetComponent<Text>().text = "Press X to Open Drawer";
			if (Input.GetKeyDown (KeyCode.X)) {
				gameObject.GetComponent<Animation> ().Play ("OpenDrawer");
				isopen = true;
			}

		}else if(isopen && !gunpickedup && !done){
			LoudSpeaker.GetComponent<Text>().text = "Press X to Pickup Gun";
			if (Input.GetKeyDown (KeyCode.X)) {
				gunpickedup = true;
				done = true;
				Destroy (Gun);
				gameObject.GetComponent<Animation> ().Play ("CloseDrawer");
			}
			if(gunpickedup){
				LoudSpeaker.GetComponent<Text>().text = "Picked Up Gun!";
				StartCoroutine (waittodisable());
			}
		}
	}
	public void OnTriggerExit(){
		if (done) {
			GameManager.instance.GunEventSequence += 1;
			gameObject.GetComponent<BoxCollider> ().enabled = false;
		} else {
			LoudSpeaker.GetComponent<Text>().text = "";
		}
	}
	IEnumerator waittodisable(){
		yield return new WaitForSeconds (5.00f);
		LoudSpeaker.GetComponent<Text>().text = "";
	}
}
