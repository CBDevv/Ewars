﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {

    private PlayerController tvPlayer;

    void Start()
    {
        tvPlayer = gameObject.GetComponentInParent<PlayerController>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        tvPlayer.grounded = true;
    }

    void OnTriggerStay2D(Collider2D col)
    {
        tvPlayer.grounded = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        tvPlayer.grounded = false;

    }
}
