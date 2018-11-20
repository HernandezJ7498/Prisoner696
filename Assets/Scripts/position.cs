using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour {

	// Use this for initialization
    public RaycastHit shot;
	public Camera camera;
	public Vector3 Distance;
	public GameObject player;
	Ray ray;
	public Vector3 cposition;
	public Vector3 result;
	Vector3 targetpos;
	void Start () {
        //GunManager.instance.Guns[1].SetActive(true);
		camera = player.GetComponent<Camera>();
		targetpos = new Vector3 (553,384,11);
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(transform.position);
	   ray = camera.ScreenPointToRay(Input.mousePosition);
       Physics.Raycast(ray, out shot);
	   Debug.DrawLine (transform.position, shot.point, Color.cyan);
		Distance = shot.point *100.0f;
		cposition = transform.position;
		result = targetpos - cposition;
		if(((Distance.x > 55300 && Distance.x < 55400) && (Distance.y > 38700 && Distance.y < 38800) && (Distance.z > -54 && Distance.z < -51)) && ((result.x < 1 && result.x >-1) && (result.y < 1 && result.y >-1) && (result.z < 1 && result.z >-1))){
			Debug.Log ("Here");
		}
	}
}
