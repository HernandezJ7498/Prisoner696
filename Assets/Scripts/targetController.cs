using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//Be Sure To Include This
 
public class targetController : MonoBehaviour {
    public static targetController TargetInstance = null;
    Camera cam; //Main Camera
    public GameObject target; //Current Focused Enemy In List
    Image image;//Image Of Crosshair
    public GameObject CrossUp;
    public GameObject CrossDown;
    public GameObject CrossLeft;
    public GameObject CrossRight;
    public GameObject CurrentEnemy;
	public GameObject player;
	float LockDistance;
    public bool lockedOn;//Keeps Track Of Lock On Status    
 
    //Tracks Which Enemy In List Is Current Target
    int lockedEnemy;
 
    //List of nearby enemies
    public static List<GameObject> nearByEnemies = new List<GameObject>();
    void Awake()
    {

        if (TargetInstance == null)
            TargetInstance = this;
        else if (TargetInstance != null)
            Destroy(gameObject);
    }
    void Start () {
        cam = Camera.main;
        image = gameObject.GetComponent<Image>();
 
        lockedOn = false;
        lockedEnemy = 0;
        image.enabled = false;
    }  
     
    void Update () { 
		if (GunManager.instance.isEnabled ((int)GunManager.Weapons.Rocket)) {
			//Press Space Key To Lock On
			if (Input.GetKeyDown (KeyCode.Tab) && !lockedOn) {
				LockDistance = Vector3.Distance (nearByEnemies [0].transform.position, player.transform.position);
				Debug.Log (LockDistance);
				if(LockDistance < 27){	
					if (nearByEnemies.Count >= 1) {
						lockedOn = true;
						image.enabled = true;
		 
						//Lock On To First Enemy In List By Default
						lockedEnemy = 0;
						target = nearByEnemies [lockedEnemy];
					}
				}
			}
	        //Turn Off Lock On When Space Is Pressed Or No More Enemies Are In The List
			else if ((Input.GetKeyDown (KeyCode.Tab) && lockedOn) || nearByEnemies.Count == 0) {
				lockedOn = false;
				image.enabled = false;
				lockedEnemy = 0;
				target = null;
				CrossUp.SetActive (true);
				CrossDown.SetActive (true);
				CrossLeft.SetActive (true);
				CrossRight.SetActive (true);
			}
	 
			//Press X To Switch Targets
			if (Input.GetKeyDown (KeyCode.T)) {
				if (lockedEnemy == nearByEnemies.Count - 1) {
					//If End Of List Has Been Reached, Start Over
					lockedEnemy = 0;
					target = nearByEnemies [lockedEnemy];
				} else {
					//Move To Next Enemy In List
					lockedEnemy++;
					target = nearByEnemies [lockedEnemy];
				}           
			}      
	 
			if (lockedOn) {
				CrossUp.SetActive (false);
				CrossDown.SetActive (false);
				CrossLeft.SetActive (false);
				CrossRight.SetActive (false);
				target = nearByEnemies [lockedEnemy];
	 
				//Determine Crosshair Location Based On The Current Target
				gameObject.transform.position = cam.WorldToScreenPoint (target.transform.position);   
	             
				//Rotate Crosshair
				gameObject.transform.Rotate (new Vector3 (0, 0, -1));
            }
            else
            {
                lockedOn = false;
                image.enabled = false;
                lockedEnemy = 0;
                target = null;
                CrossUp.SetActive(true);
                CrossDown.SetActive(true);
                CrossLeft.SetActive(true);
                CrossRight.SetActive(true);
            }             
		} else {
			//image.enabled = false;
		}
        //Debug.Log("here");
	}
}