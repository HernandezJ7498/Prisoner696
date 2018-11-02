using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour {

	// Use this for initialization
	public static int PlayerHealth = 10;
	public int InternalHealth;
	public int kills;
	public GameObject HealthDisplay;
	public GameObject KillCount;
	void Start(){

	}
	void Update(){
		InternalHealth = PlayerHealth;
		kills = GameManager.instance.KillCount;
		HealthDisplay.GetComponent<Text> ().text = "Health: " + PlayerHealth;
		KillCount.GetComponent<Text> ().text = "Kill Count: " + kills;
		if (PlayerHealth == 0) {
			//SceneManager.LoadScene (1);
		}
	}
}
