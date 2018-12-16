using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour {

	// Use this for initialization
	public GameObject SpotLight;
	public GameObject AreaLight;
	float number;
	public int LightColor;
	public Material Yellow;
	public Material DarkYellow;
	public GameObject Lamp;
	void Start () {
		StartCoroutine (LightFlickerRoutine());
		LightColor = 1;
	}
	
	// Update is called once per frame
	void Update () {
		/*if(GameManager.instance.ElevatorPower && !ExecuteOnce){
			SpotLight.GetComponent<Light>().enabled = !SpotLight.GetComponent<Light>().enabled;
			AreaLight.GetComponent<Light>().enabled = !AreaLight.GetComponent<Light>().enabled;
			ExecuteOnce = true;
		}*/
	}
	IEnumerator LightFlickerRoutine(){
		while(!GameManager.instance.ElevatorPower){
			number = Random.Range (0.0f, .9f);
			if (LightColor % 2 == 1) {
				Lamp.GetComponent<MeshRenderer> ().material = Yellow;
			} else {
				Lamp.GetComponent<MeshRenderer> ().material = DarkYellow;
			}
			yield return new WaitForSeconds(number);
			SpotLight.GetComponent<Light>().enabled = !SpotLight.GetComponent<Light>().enabled;
			AreaLight.GetComponent<Light>().enabled = !AreaLight.GetComponent<Light>().enabled;
			LightColor++;
		}

		
	}
}
