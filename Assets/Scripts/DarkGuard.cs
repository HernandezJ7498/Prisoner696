using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkGuard : MonoBehaviour {

	// Use this for initialization
	public int EnemyHealth;
	void Start () {
		EnemyHealth = GameManager.instance.DarkGuardHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (EnemyHealth <= 0) {
			Destroy (gameObject);
			GameManager.instance.KillCount += 1;
		}
	}

	void DeductPoints(int DamageAmount){
		EnemyHealth -= DamageAmount;
	}
}
