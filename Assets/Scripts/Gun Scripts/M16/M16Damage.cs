﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M16Damage : MonoBehaviour {

	// Use this for initialization
	public int DamageAmount = 1;
	public float TargetDistance;
	public float AllowedRange = 15;
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			RaycastHit shot;
			if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out shot)) {
				TargetDistance = shot.distance;
				//Debug.Log (shot.distance);
				if (TargetDistance < AllowedRange) {
					shot.transform.SendMessage ("DeductPoints", DamageAmount, SendMessageOptions.DontRequireReceiver);

				}
			}
		}
	}
}
