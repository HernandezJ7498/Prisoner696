using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGuardFollow : MonoBehaviour {

	// Use this for initialization
	public GameObject ThePlayer;
	public float TargetDistance;
	public float allowedRange = 50;
	public int howclose = 4; 
	public GameObject TheEnemy ;
	public float EnemySpeed;
	public int AttackTrigger;
	public RaycastHit shot;
	public int IsAttacking;
	public GameObject ScreenFlash;
	public AudioSource Hurt01;
	public AudioSource Hurt02;
	public AudioSource Hurt03;
	public int PainSound;
	void Start () {
		TheEnemy = GameObject.FindWithTag ("RedMonster");
		ThePlayer = GameObject.FindWithTag("Player");
		//ScreenFlash = GameObject.Find("HurtUI");
		Hurt01 = GameObject.Find("Hurt01").GetComponent<AudioSource>();
		Hurt02 = GameObject.Find("Hurt02").GetComponent<AudioSource>();
		Hurt03 = GameObject.Find("Hurt02").GetComponent<AudioSource>();
	//public Animator anim;	
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log (AttackTrigger);
		/*if(TargetDistance < allowedRange){
			AttackTrigger = 1;
		}else{
			AttackTrigger = 0;
		}*/
		transform.LookAt (ThePlayer.transform);
		if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out shot)) {
			TargetDistance = shot.distance;
			if (TargetDistance < allowedRange) {
				AttackTrigger = 1;
				EnemySpeed = 0.01f;
				TheEnemy.GetComponent<Animator> ().SetTrigger ("iSeePlayer");
				transform.position = Vector3.MoveTowards (transform.position, ThePlayer.transform.position, EnemySpeed);

			} else {
				AttackTrigger = 0;
				EnemySpeed = 0;
				TheEnemy.GetComponent<Animator> ().SetTrigger ("iDontSeePlayer");
			}
			if (AttackTrigger == 1 && TargetDistance < howclose) {
				//Debug.Log (IsAttacking);
				if (IsAttacking == 0) {
					StartCoroutine (EnemyDamage ());
				}
				//TheEnemy.GetComponent<Animator> ().SetBool ("attacks", true);
				//TheEnemy.GetComponent<Animator> ().SetBool ("attacks", false);
				//EnemySpeed = 0f;
			}
		}
	}
	void OnTriggerStay(){
		//Debug.Log ("Here");
		//AttackTrigger = 1;
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

