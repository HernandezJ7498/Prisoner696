using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTrigger : MonoBehaviour {

	// Use this for initialization
	public bool[] cubes;
	public GameObject Gate;
	public bool IsOpen;
	void Start () {
		cubes = new bool[4];
	}
	
	// Update is called once per frame
	void Update () {
		if (checkiftrue () && !IsOpen) {
			Gate.GetComponent<Animation> ().Play ("CafCubePuzzleOpen");
			IsOpen = true;
		}
	}
	void OnTriggerEnter(Collider other){
		if (!IsOpen) {
			cubes [other.GetComponent<MyNum> ().MyNumber] = true;
		}
	}
	void OnTriggerExit(Collider other){
		if (!IsOpen) {
			cubes [other.GetComponent<MyNum> ().MyNumber] = false;
		}
	}
	private bool  checkiftrue(){
		for(int i = 0;i<cubes.Length;i++){
			if (cubes [i] == false) {
				return false;
			}
		}
		return true;
	}
}
