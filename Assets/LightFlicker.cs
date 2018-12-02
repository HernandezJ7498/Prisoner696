using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour {

	// Use this for initialization
	public GameObject SpotLight;
	public GameObject AreaLight;
	float number;
	bool ExecuteOnce;
	void Start () {
		StartCoroutine (LightFlickerRoutine());
	}
	
	// Update is called once per frame
	void Update () {
		if(GameManager.instance.ElevatorPower && !ExecuteOnce){
			SpotLight.GetComponent<Light>().enabled = !SpotLight.GetComponent<Light>().enabled;
			AreaLight.GetComponent<Light>().enabled = !AreaLight.GetComponent<Light>().enabled;
			ExecuteOnce = true;
		}
	}
	IEnumerator LightFlickerRoutine(){
		while(!GameManager.instance.ElevatorPower){
			number = Random.Range (0.0f, .9f);
			yield return new WaitForSeconds(number);
			SpotLight.GetComponent<Light>().enabled = !SpotLight.GetComponent<Light>().enabled;
			AreaLight.GetComponent<Light>().enabled = !AreaLight.GetComponent<Light>().enabled;
		}

		
	}
}
