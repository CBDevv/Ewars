﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticlePlatform : MonoBehaviour
{

    private PlatformEffector2D theEffector;
    private float waitTime;

    // Start is called before the first frame update
    void Start()
    {
        theEffector = GetComponent<PlatformEffector2D>();
        theEffector.rotationalOffset = 0f;
        waitTime = 0.0f;

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("Vertical"))
        //{
        //    //waitTime = 0.1f;
        //    theEffector.rotationalOffset = 0f;
        //}

        if (Input.GetButtonUp("Vertical"))
        {
            //waitTime = 0.1f;
            theEffector.rotationalOffset = 0f;
        }

        if (Input.GetButtonDown("Vertical"))
        {
            if(waitTime < 0)
            {
                theEffector.rotationalOffset = 180f;
                //waitTime = 0.1f;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }

        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    theEffector.rotationalOffset = 0f;
        //}
    }
}
