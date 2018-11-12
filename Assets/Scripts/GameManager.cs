using System.Collections;
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
	public bool OpenSniperRoom = false;
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
    public int KeyParts;
    public bool HasAllKeys = false;
    public int Locks = 2;
    public GameObject Bridge;
    float timeLeft = 16.0f;
    public GameObject tdisplay;
    float minutes;
    float seconds;
    string seconds1;
	public bool IsTimerOn = false;
	bool BridgeIsActive = false;


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
        KeyParts = 0;
	}
	
	// Update is called once per frame
	void Update () {
       // Debug.Log(activeSwitches);
        if(ActiveSwitches == 3){
            Destroy(GameObject.Find("TEMPSECRETDOOR"));
        }
		if(CafDoorIsOpen){
			Destroy(GameObject.Find("TEMPCAFDOOR"));
		}
        if(ActiveButtons == 3){
            ActivateBridge();
            ActiveButtons = 4; 
			BridgeIsActive = true;
			tdisplay.GetComponent<Text> ().text = "";
        }
		if(KillCount > 3 && !level1){
			UnicornGuardHealth = 6;
			level1 = true;
		}
		if(KillCount > 10 && !level2){
			UnicornGuardHealth = 9;
			level2 = true;
		}
        if(Locks == 0){
            Destroy(GameObject.Find("TEMPBACKDOOR"));
        }
		if(IsTimerOn && !BridgeIsActive){
			timeLeft -= Time.deltaTime;
	       // tdisplay.GetComponent<Text>().text = timeLeft.ToString();
	        minutes = Mathf.Floor(timeLeft / 60);
	        seconds = Mathf.RoundToInt(timeLeft % 60);
	        seconds1 = seconds.ToString();
	        if (seconds < 10)
	        {
	            seconds =  Mathf.RoundToInt(seconds);
	            seconds1 = "0" + seconds.ToString();
	        }
	        tdisplay.GetComponent<Text>().text = minutes.ToString() + ":" + seconds1;//GUI.Label(new Rect(10, 10, 250, 100), minutes + ":" + seconds);
			if(minutes == 0 && seconds == 0){
				BridgeReset ();
			}
		}

			// Debug.Log(KeyParts);
        //Debug.Log(HasAllKeys);
	}
	void BridgeReset(){
		IsTimerOn = false;
		timeLeft = 16.0f;
		for (int i = 0; i < Buttons.Length; i++) {
			Buttons [i] = false;
		}
		ActiveButtons = 0;
		tdisplay.GetComponent<Text> ().text = "";
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
			Lamps[whichbutton].GetComponent<Light>().color = LampColor[whichbutton];
			Buttons [whichbutton] = true;
			ActiveButtons += 1;
		}
    }
    public void ActivateBridge(){
        Bridge.GetComponent<Animation>().Play("CreateBridge");

    }

}
