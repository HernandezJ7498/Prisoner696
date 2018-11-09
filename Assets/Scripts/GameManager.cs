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
    float timeLeft = 30.0f;
    public GameObject tdisplay;

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
        timeLeft -= Time.deltaTime;
        tdisplay.GetComponent<Text>().text = timeLeft.ToString();
        
       // Debug.Log(KeyParts);
        //Debug.Log(HasAllKeys);
	}
    public void collect(GameObject passedObject){
        
        Destroy(passedObject);
    }
    public void switchon(int whichswitch){
        Switches[whichswitch] = true;
        ActiveSwitches+= 1;
    }
    public void buttontrigger(int whichbutton){
        Buttons[whichbutton] = true;
        ActiveButtons+= 1;
    }
    public void ActivateBridge(){
        Bridge.GetComponent<Animation>().Play("MovingFloor");

    }

}
