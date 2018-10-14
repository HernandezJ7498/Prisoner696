using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeLevels : MonoBehaviour {

	// Use this for initialization
    public GameObject player;
	void Start () {
		//GameObject player = GameObject.Find("FSController");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(){
        player.transform.position = new Vector3(579.8f, 375f, -12.5f);
    }
}
