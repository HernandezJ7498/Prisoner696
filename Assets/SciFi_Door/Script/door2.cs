using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class door2 : MonoBehaviour {
	GameObject thedoor;

	void OnTriggerEnter ( Collider obj  ){
				thedoor = GameObject.FindWithTag ("SF_Door2");
				thedoor.GetComponent<Animation> ().Play ("open");

	}

	void OnTriggerExit ( Collider obj  ){
			thedoor = GameObject.FindWithTag ("SF_Door2");
			thedoor.GetComponent<Animation> ().Play ("close");
	}
}