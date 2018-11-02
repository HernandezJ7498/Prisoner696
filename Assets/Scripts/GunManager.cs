using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

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
	public enum Weapons {M9, Shotgun, M16, ColtPython, Sniper, Crowbar};
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void DisableGuns(){
		for (int i = 0; i < Guns.Length; i++) {
			Guns[i].SetActive(false);
		}
	}
	public void EnableGun(int TheWeapon){
		Guns[TheWeapon].SetActive(true);
	}
}
