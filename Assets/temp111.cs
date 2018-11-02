using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temp111 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(GameManager.instance.HasAllKeys);
	}
    private void OnTriggerEnter()
    {
        GameManager.instance.HasAllKeys = true;
    }
}
