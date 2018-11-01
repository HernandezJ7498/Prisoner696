using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGuard : MonoBehaviour {

	// Use this for initialization
	public int EnemyHealth = 10;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (EnemyHealth <= 0) {
			Destroy (gameObject);
		}
	}

	void DeductPoints(int DamageAmount){
		EnemyHealth -= DamageAmount;
	}
}
