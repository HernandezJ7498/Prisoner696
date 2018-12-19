using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GunManager : MonoBehaviour {

	// Use this for initialization
    public static GunManager instance = null;
    public GameObject[] Guns;
	public GameObject Up;
	public GameObject Left;
	public GameObject Right;
	public GameObject Down;
    void Awake(){
        if(instance == null)
            instance = this;
        else if (instance != null)
            Destroy (gameObject);
    }
	public enum Weapons {Rocket, Crowbar, Scanner, Wood};
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void DisableGuns(){
		Up.SetActive (false);
		Down.SetActive (false);
		Left.SetActive (false);
		Right.SetActive (false);
		for (int i = 0; i < Guns.Length; i++) {
			Guns[i].SetActive(false);
		}
	}
	public void EnableGun(int TheWeapon){
		Guns[TheWeapon].SetActive(true);
	}
	public bool isEnabled(int TheWeapon){
		return Guns [TheWeapon].activeSelf;
	}
}
