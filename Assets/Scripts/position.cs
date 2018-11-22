﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class position : MonoBehaviour
{

    // Use this for initialization
    public RaycastHit shot;
    public Camera camera;
    public Vector3 Distance;
    public GameObject player;
    Ray ray;
    public Vector3 cposition;
    public Vector3 result;
    Vector3 targetpos;
    bool done;
    bool inside;
    //CursorLockMode wantedmode;
    void Start()
    {
        //GunManager.instance.Guns[1].SetActive(true);
        camera = player.GetComponent<Camera>();
        targetpos = new Vector3(553, 384, 11);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.position);
        ray = camera.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out shot);
        Debug.DrawLine(transform.position, shot.point, Color.cyan);
        Distance = shot.point * 100.0f;
        cposition = transform.position;
        result = targetpos - cposition;
        if (((Distance.x > 56877 && Distance.x < 56878) && (Distance.y > 38589 && Distance.y < 38679) && (Distance.z > 235 && Distance.z < 380)))
        {// && ((result.x < 1 && result.x >-1) && (result.y < 1 && result.y >-1) && (result.z < 1 && result.z >-1))){
            if (!done)
            {
                Cursor.visible = true;//(CursorLockMode.Locked != wantedmode);
                Cursor.lockState = CursorLockMode.None;
                //GameManager.instance.paused = true;
                gameObject.GetComponent<FirstPersonController>().enabled = false;
                // done = false;
                //gameObject.GetComponent<MouseLook> ().enabled;
                inside = true;
            }
            else if (done)
            {
                gameObject.GetComponent<FirstPersonController>().enabled = true;
            }
            /*} else {
                //GameManager.instance.paused = false;
                if(inside && done){
                    gameObject.GetComponent<FirstPersonController>().enabled = true;
                   // inside = false;
                }
                //done = false;
                //inside = false;
            }*/
        }
        else
        {
            done = false;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            done = true;
        }
    }
}