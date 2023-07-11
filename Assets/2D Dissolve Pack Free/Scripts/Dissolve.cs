﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour
{
    Animator anim;

     void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            DissolveOut();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            DissolveIn();
        }
    }

    public void DissolveOut()
    {
        anim.SetTrigger("DissolveOut");
    }

    public void DissolveIn()
    {
        anim.SetTrigger("DissolveIn");
    }
}
