﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerOnX : MonoBehaviour
{
    Rigidbody2D thisRB;
    public Rigidbody2D player;
    // Start is called before the first frame update
    void Start()
    {
        thisRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        thisRB.velocity = new Vector2(player.velocity.x, thisRB.velocity.y);
    }//always follows the players X speed, keeps object small, TODO: maybe just make a check in player controller, depending on which takes less memory
}