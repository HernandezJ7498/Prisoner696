using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	public static int thevalue = 5;
    public static GameManager instance = null;
    public bool haskey = false;
    public bool[] switches;
    public int activeSwitches;
    void Awake(){
        
        if(instance == null)
            instance = this;
        else if (instance != null)
            Destroy (gameObject);
    }
    void Start () {
		switches = new bool[3];
        activeSwitches = 0;
	}
	
	// Update is called once per frame
	void Update () {
       // Debug.Log(activeSwitches);
        if(activeSwitches == 3){
            Destroy(GameObject.Find("TEMPSECRETDOOR"));
        }

	}
    public void collect(GameObject passedObject){
        
        Destroy(passedObject);
    }
    public void switchon(int whichswitch){
        switches[whichswitch] = true;
        activeSwitches+= 1;
    }

}
