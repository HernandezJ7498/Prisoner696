using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodSwing : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(GunManager.instance.isEnabled((int)GunManager.Weapons.Wood) && GameManager.instance.WoodEnabled){
			if (Input.GetKeyDown (KeyCode.Mouse0)) {
				gameObject.GetComponent<Animation> ().Play ("swingwood");
				GameManager.instance.IsSwinggingWood = true;
				StartCoroutine (woodwait());
			}

		}
	}
	IEnumerator woodwait(){
		yield return new WaitForSeconds (1);
		GameManager.instance.IsSwinggingWood = false;
	}
}
