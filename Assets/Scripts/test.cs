using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class test : MonoBehaviour
{

	// Use this for initialization
	public RaycastHit shot;
	public float dist;
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out shot);
		dist = shot.distance;
	}
}
