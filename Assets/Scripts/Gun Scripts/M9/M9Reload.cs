using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M9Reload : MonoBehaviour {

	// Use this for initialization
	public AudioSource ReloadSound;
	public GameObject CrossObject;
	public GameObject MechanicsObject;
	int ClipCount;
	int ReserveCount;
	int ReloadAvailable;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ClipCount = GlobalAmmo.LoadedAmmo;
		ReserveCount = GlobalAmmo.CurrentAmmo;
		if (ReserveCount == 0) {
			ReloadAvailable = 0;
		} else {
			ReloadAvailable = 10 - ClipCount;
		}
		if (Input.GetKeyDown ("f")) {
			if(ReloadAvailable >= 1){
				if (ReserveCount <= ReloadAvailable) {
					GlobalAmmo.LoadedAmmo += ReserveCount;
					GlobalAmmo.CurrentAmmo -= ReserveCount;
					ActionReload ();
				} else {
					GlobalAmmo.LoadedAmmo += ReloadAvailable;
					GlobalAmmo.CurrentAmmo -= ReloadAvailable;
					ActionReload ();
				}
			}
		}
		StartCoroutine(EnableScripts ());

	}
	IEnumerator EnableScripts(){
		yield return new WaitForSeconds (1.1f);
		this.GetComponent<GunFire>().enabled = true;
		CrossObject.SetActive (true);
		MechanicsObject.SetActive (true);
	}
	void ActionReload(){
		this.GetComponent<GunFire>().enabled = false;
		CrossObject.SetActive (false);
		MechanicsObject.SetActive (false);
		//ReloadSound.Play ();
		//GetComponent<Animation> ().Play ("M9Reload");
	}
}
