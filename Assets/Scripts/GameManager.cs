﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	public static int thevalue = 5;
    public static GameManager instance = null;
    public bool HasSecretKey = false;
	public bool HasElevatorKey = false;
	public bool[] Switches;
    public bool[] Buttons;
	public GameObject[] Lamps;
	public Color[] LampColor;
    public int ActiveSwitches;
    public int ActiveButtons;
	public bool ElevatorPower = false;
	public bool ComputersOn = false;
	public bool CafDoorIsOpen = false;
	public bool PanelActive = false;
	public int FireGuardHealth = 10;
	public int EarthGuardHealth = 10;
	public int SunGuardHealth = 10;
	public int UnicornGuardHealth = 3;
	public int DarkGuardHealth = 10;
	public int KillCount = 0;
	bool level1 = false;
	bool level2 = false;
    public bool HasLastKey = false;
    public int Locks = 2;
    public GameObject Bridge;
    float timeLeft = 20.0f;
    public GameObject tdisplay;
    float minutes;
    float seconds;
    string seconds1;
	public bool IsTimerOn = false;
	public bool BridgeIsActive = false;
	public GameObject LampCam;
	public bool GlassesOn = false;
	public bool FoundGlasses = false;
	public GameObject Glasses;
	public GameObject GlassesDarkness;
    public GameObject Crosshair;
	public GameObject HeatWave;
	public GameObject BoltPuzzle;
	public GameObject BridgeLight;
	public bool LeftTrigger;
	public bool RightTrigger;
	bool BoltsTriggered;
	public bool InSight;
	public bool CubeInSight;
	public bool LeftBlockTrigger;
	public bool RightBlockTrigger;
	public GameObject LastDoor;
	public bool LastDoorIsOpen;
	public bool LastTriggerLeft;
	public bool LastTriggerRight;
	public bool ElevatorKeyRoomSwitches;
	public bool CrowbarEnabled;
	public bool RocketEnabled;
	public bool ScannerEnabled;
	public bool WoodEnabled;
	public bool IsSwinggingWood;
	public bool VentBroke;
	public bool BeganBathroomSequence;
	public bool BeganGunSequence;
	public bool ToiletPaper1Pickup;
	public bool ToiletPaper2Pickup;
	public int GunEventSequence;
	public int BuschmannEventSequence;
	public GameObject CellBlockKeyHud;
	public GameObject ElevatorKeyHud;
	public GameObject LastKeyHud;
	public GameObject Dot;
	public GameObject ScannerPanel;
	public GameObject ToiletPaperPicture;
	public Vector3 GameManagerPointOfImpact;



    void Awake(){
        
        if(instance == null)
            instance = this;
        else if (instance != null)
            Destroy (gameObject);
    }
    void Start () {
		Switches = new bool[3];
        ActiveSwitches = 0;
        Buttons = new bool[3];
		Lamps = new GameObject[3];
		LampColor = new Color[3];
		Lamps [0] = GameObject.Find ("GreenLamp");
		Lamps [1] = GameObject.Find ("BlueLamp");
		Lamps [2] = GameObject.Find ("RedLamp");
		LampColor [0] = Color.green;
		LampColor [1] = Color.blue;
		LampColor [2] = Color.red;
        ActiveButtons = 0;
		FireGuardHealth = 10;
		EarthGuardHealth = 10;
		SunGuardHealth = 10;
		UnicornGuardHealth = 3;
		DarkGuardHealth = 10;
		LampCam.SetActive (false);
        Cursor.visible = true;
		Glasses.SetActive (false);
		GlassesDarkness.SetActive (false);
        Cursor.lockState = CursorLockMode.Locked;
		GunEventSequence = 0;
	}
	void Update () {
        if(ActiveSwitches == 3){
			ElevatorKeyRoomSwitches = true;
        }
		if(CafDoorIsOpen){
			Destroy(GameObject.Find("TEMPCAFDOOR"));
		}
        if(ActiveButtons == 3){
            ActivateBridge();
            ActiveButtons = 4; 
			BridgeIsActive = true;
			tdisplay.GetComponent<Text> ().text = "";
			LampCam.GetComponent<Animation> ().Play ("ShowBridge");
			StartCoroutine (DisableBridgeCamera());
        }
		if(IsTimerOn && !BridgeIsActive){
			timeLeft -= Time.deltaTime;
	        minutes = Mathf.Floor(timeLeft / 60);
	        seconds = Mathf.RoundToInt(timeLeft % 60);
	        seconds1 = seconds.ToString();
	        if (seconds < 10)
	        {
	            seconds =  Mathf.RoundToInt(seconds);
	            seconds1 = "0" + seconds.ToString();
	        }
	        tdisplay.GetComponent<Text>().text ="Time Left: " + minutes.ToString() + ":" + seconds1;//GUI.Label(new Rect(10, 10, 250, 100), minutes + ":" + seconds);
			if(minutes == 0 && seconds == 0){
				BridgeReset ();
			}
		}
        if (!GlassesOn && Input.GetKeyUp(KeyCode.G) && FoundGlasses)
        {
			Glasses.SetActive(true);
			Glasses.GetComponent<Animation>().Play ("glasses");
			StartCoroutine (GlassesToggle("ON"));
			GlassesOn = true;
		}else if(GlassesOn && Input.GetKeyUp(KeyCode.G) && FoundGlasses){
			Glasses.SetActive(true);
			Glasses.GetComponent<Animation>().Play ("glassesoff");
			StartCoroutine (GlassesToggle("OFF"));
			GlassesOn = false;
		}
		if (LeftTrigger && RightTrigger && !BoltsTriggered) {
			BoltPuzzle.GetComponent<Animation> ().Play ("CafeteriaBigGateOpening");
			BoltsTriggered = true;
		}
		if (LeftBlockTrigger && RightBlockTrigger && !LastDoorIsOpen) {
			LastDoor.GetComponent<Animation> ().Play ("OpenLastDoor");
			LastDoorIsOpen = true;
		}
		if (Input.GetKeyDown ("1")) {
			Dot.SetActive (true);
			ScannerPanel.SetActive (false);
			GunManager.instance.DisableGuns ();
			Dot.SetActive (true);
		}
		if (Input.GetKeyDown ("2") && RocketEnabled) {
			Dot.SetActive (false);
			ScannerPanel.SetActive (false);
			GunManager.instance.DisableGuns ();
			GunManager.instance.EnableGun ((int)GunManager.Weapons.Rocket);
		}
		if (Input.GetKeyDown ("3") && CrowbarEnabled) {
			Dot.SetActive (false);
			ScannerPanel.SetActive (false);
			GunManager.instance.DisableGuns ();
			GunManager.instance.EnableGun ((int)GunManager.Weapons.Crowbar);
		}
		if (Input.GetKeyDown ("4") && ScannerEnabled) {
			ScannerPanel.SetActive (true);
			Dot.SetActive (true);
			GunManager.instance.DisableGuns ();
			GunManager.instance.EnableGun ((int)GunManager.Weapons.Scanner);
		}
		if (Input.GetKeyDown ("5") && WoodEnabled) {
			Dot.SetActive (true);
			ScannerPanel.SetActive (false);
			GunManager.instance.DisableGuns ();
			GunManager.instance.EnableGun ((int)GunManager.Weapons.Wood);
		}
		if (ToiletPaper1Pickup || ToiletPaper2Pickup) {
			ToiletPaperPicture.SetActive (true);
		} else {
			ToiletPaperPicture.SetActive (false);
		}
		if (HasSecretKey) {
			CellBlockKeyHud.SetActive (true);
		} else {
			CellBlockKeyHud.SetActive (false);
		}
		if (HasElevatorKey) {
			ElevatorKeyHud.SetActive (true);
		} else {
			ElevatorKeyHud.SetActive (false);
		}
		if (HasLastKey) {
			LastKeyHud.SetActive (true);
		} else {
			LastKeyHud.SetActive (false);
		}
	}
	void BridgeReset(){
		IsTimerOn = false;
		timeLeft = 20.0f;
		for (int i = 0; i < Buttons.Length; i++) {
			Buttons [i] = false;
		}
		ActiveButtons = 0;
		tdisplay.GetComponent<Text> ().text = "";
		Lamps [0].GetComponent<Light> ().color = Color.white;
		Lamps[1].GetComponent<Light>().color = Color.white;
		Lamps[2].GetComponent<Light>().color = Color.white;
		LampCam.SetActive (false);

	}
    public void collect(GameObject passedObject){
        
        Destroy(passedObject);
    }
    public void switchon(int whichswitch){
        Switches[whichswitch] = true;
        ActiveSwitches+= 1;
    }
    public void buttontrigger(int whichbutton){
		if (Buttons [whichbutton] != true) {
			IsTimerOn = true;
			Lamps[whichbutton].GetComponent<Light>().color = LampColor[whichbutton];
			Buttons [whichbutton] = true;
			ActiveButtons += 1;
			LampCam.SetActive (true);
			if (whichbutton == 0) {
				if (!Buttons [2]) {
					BridgeReset ();
					IsTimerOn = false;
					tdisplay.GetComponent<Text> ().text = "";
					LampCam.SetActive (false);
					IsTimerOn = false;
				}
			}else if (whichbutton == 1) {
				if (!Buttons [0] || !Buttons[2]) {
					BridgeReset ();
					IsTimerOn = false;
					tdisplay.GetComponent<Text> ().text = "";
					LampCam.SetActive (false);
					IsTimerOn = false;
				}
			}
		}
    }
    public void ActivateBridge(){
        Bridge.GetComponent<Animation>().Play("CreateBridge");

    }
	IEnumerator DisableBridgeCamera(){
		yield return new WaitForSeconds (8.5f);
		LampCam.SetActive (false);
		HeatWave.SetActive (false);
		BridgeLight.SetActive (false);
	}
	IEnumerator GlassesToggle(string Action){
		if (Action == "ON") {
			yield return new WaitForSeconds (1.0f);
			Glasses.SetActive (false);
			GlassesDarkness.SetActive (true);
		} else {
			yield return new WaitForSeconds (1.0f);
			Glasses.SetActive (false);
			GlassesDarkness.SetActive (false);
		}
	}

}
