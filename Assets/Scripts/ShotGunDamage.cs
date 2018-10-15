﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGunDamage : MonoBehaviour {

	// Use this for initialization
	public int DamageAmount = 10;
	public float TargetDistance;
	public float AllowedRange = 15;
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			RaycastHit shot;
			Debug.Log ("First");
			if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out shot)) {
				Debug.Log ("Second");
				TargetDistance = shot.distance;
				Debug.Log (shot.distance);
				if (TargetDistance < AllowedRange) {
					shot.transform.SendMessage ("DeductPoints", DamageAmount, SendMessageOptions.DontRequireReceiver);

				}
			}
			Debug.Log ("Third");
		}
	}
}