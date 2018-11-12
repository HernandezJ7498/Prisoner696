using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossAnimate : MonoBehaviour {

	// Use this for initialization
	public GameObject UpCursor;
	public GameObject DownCursor;
	public GameObject LeftCursor;
	public GameObject RightCursor;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GlobalAmmo.LoadedAmmo >= 1) {
			if (Input.GetMouseButtonDown (0)) {
				UpCursor.GetComponent<Animator> ().enabled = true;
				DownCursor.GetComponent<Animator> ().enabled = true;
				LeftCursor.GetComponent<Animator> ().enabled = true;
				RightCursor.GetComponent<Animator> ().enabled = true;
				StartCoroutine (WaitingAnim ());
			}
		}
	}
	IEnumerator WaitingAnim(){
		yield return new WaitForSeconds(0.1f);
		UpCursor.GetComponent<Animator> ().enabled = false;
		DownCursor.GetComponent<Animator> ().enabled = false;
		LeftCursor.GetComponent<Animator> ().enabled = false;
		RightCursor.GetComponent<Animator> ().enabled = false;
	}
}
