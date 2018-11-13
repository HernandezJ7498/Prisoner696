﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockHealth : MonoBehaviour
{

    // Use this for initialization
    public GameObject ThePlayer;
    public float TargetDistance;
    public RaycastHit shot;
    public int AllowedRangeMin = 15;
    public int AllowedRangeMax = 16;
    void Start()
    {
        ThePlayer = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(ThePlayer.transform);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
        {
            TargetDistance = shot.distance;
            if (TargetDistance > AllowedRangeMin && TargetDistance < AllowedRangeMax)
            {
                this.GetComponent<enemyInView>().InRange = true;
            }
            else
            {
                this.GetComponent<enemyInView>().InRange = false;
            }
        }
    }
}
