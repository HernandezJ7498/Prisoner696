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
    public int ActiveSwitches;
	public bool ElevatorPower = false;
	public bool OpenSniperRoom = false;

    void Awake(){
        
        if(instance == null)
            instance = this;
        else if (instance != null)
            Destroy (gameObject);
    }
    void Start () {
		Switches = new bool[3];
        ActiveSwitches = 0;
	}
	
	// Update is called once per frame
	void Update () {
       // Debug.Log(activeSwitches);
        if(ActiveSwitches == 3){
            Destroy(GameObject.Find("TEMPSECRETDOOR"));
        }
	}
    public void collect(GameObject passedObject){
        
        Destroy(passedObject);
    }
    public void switchon(int whichswitch){
        Switches[whichswitch] = true;
        ActiveSwitches+= 1;
    }

}
