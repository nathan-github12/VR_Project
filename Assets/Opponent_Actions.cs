﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opponent_Actions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider trigger) {
        if(trigger.gameObject.tag == "Player"){
            print("Opponent has been hit");
        }
    }
}
