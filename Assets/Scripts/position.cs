using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour {

	// Use this for initialization
    public RaycastHit shot;
	void Start () {
        //GunManager.instance.Guns[1].SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(transform.position);
       // Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot);
        //Debug.Log(shot.distance);
	}
}
