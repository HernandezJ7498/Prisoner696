using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

	// Use this for initialization
	public GameObject ThePlayer;
	public GameObject TheEnemy;
	public float EnemySpeed;
	public int MoveTrigger;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (MoveTrigger == 0) {
			EnemySpeed = 0.02f;
			transform.position = Vector3.MoveTowards (transform.position, ThePlayer.transform.position, EnemySpeed);
		}
	}
}
