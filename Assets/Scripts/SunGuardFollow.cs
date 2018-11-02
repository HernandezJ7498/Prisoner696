using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunGuardFollow : MonoBehaviour {

	// Use this for initialization
	public GameObject ThePlayer;
	public float TargetDistance;
	public float allowedRange;
	public GameObject TheEnemy ;
	public float EnemySpeed;
	public int AttackTrigger;
	public RaycastHit shot;
	public int IsAttacking;
	public GameObject ScreenFlash;
	public AudioSource Hurt01;
	public AudioSource Hurt02;
	public AudioSource Hurt03;
	public Light Light1;
	public Light Light2;
	public Light Light3;
	int R1;
	int R2;
	int R3;
	public int PainSound;
	void Start () {
		TheEnemy = GameObject.FindWithTag ("SunGuard");
		ThePlayer = GameObject.FindWithTag("Player");
		//ScreenFlash = GameObject.Find("HurtUI");
		//ScreenFlash.SetActive (false);
		Hurt01 = GameObject.Find("Hurt01").GetComponent<AudioSource>();
		Hurt02 = GameObject.Find("Hurt02").GetComponent<AudioSource>();
		Hurt03 = GameObject.Find("Hurt02").GetComponent<AudioSource>();
		Light1 = GameObject.Find("Light1").GetComponent<Light>();
		Light2 = GameObject.Find("Light2").GetComponent<Light>();
		Light3 = GameObject.Find("Light3").GetComponent<Light>();
		allowedRange = 50;
		//public Animator anim;	
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log (AttackTrigger);
		transform.LookAt (ThePlayer.transform);
		if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot)){
			TargetDistance = shot.distance;
			if(TargetDistance < allowedRange){
				EnemySpeed = 0.03f;
				if(AttackTrigger == 0){
					//TheEnemy.GetComponent<Animator> ().SetTrigger ("iSeePlayer");
					transform.position = Vector3.MoveTowards (transform.position, ThePlayer.transform.position, EnemySpeed);
					R1 = Random.Range (0,30);
					R2 = Random.Range (0,30);
					R3 = Random.Range (0,30);
					if(R1 == 22){
						Light1.enabled = !Light1.enabled;
					}
					if(R2 == 15){
						Light2.enabled = !Light2.enabled;
					}
					if(R3 == 2){
						Light3.enabled = !Light3.enabled;
					}
				}
			}
			else{
				EnemySpeed = 0;
				TheEnemy.GetComponent<Animator> ().SetTrigger ("iDontSeePlayer");
			}
		}
		if (AttackTrigger == 1) {
			//Debug.Log (IsAttacking);
			if (IsAttacking == 0) {
				StartCoroutine (EnemyDamage ());
			}
			TheEnemy.GetComponent<Animator> ().SetBool ("attacks", true);
			//TheEnemy.GetComponent<Animator> ().SetBool ("attacks", false);
			EnemySpeed = 0f;
		}
	}
	void OnTriggerStay(){
		//Debug.Log ("Here");
		AttackTrigger = 1;
	}
	void OnTriggerExit(){
		AttackTrigger = 0;
		TheEnemy.GetComponent<Animator> ().SetBool ("attacks", false);
	}
	IEnumerator EnemyDamage(){
		IsAttacking = 1;
		PainSound = Random.Range (1, 4);
		yield return new WaitForSeconds (0.9f);
		//ScreenFlash.SetActive (true);
		GlobalHealth.PlayerHealth -= 1;
		if (PainSound == 1) {
			Hurt01.Play ();
		} else if (PainSound == 2) {
			Hurt02.Play ();
		} else {
			Hurt03.Play ();
		}
		yield return new WaitForSeconds(0.02f);
		//ScreenFlash.SetActive(false);
		yield return new WaitForSeconds(1);
		//TheEnemy.GetComponent<Animator> ().SetTrigger ("here");
		IsAttacking = 0;

	}
}

