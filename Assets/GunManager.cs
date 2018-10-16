using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour {

	// Use this for initialization
    public static GunManager instance = null;
    public GameObject[] Guns;
    void Awake(){
        if(instance == null)
            instance = this;
        else if (instance != null)
            Destroy (gameObject);
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
