﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Actions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider trigger){
        if(trigger.gameObject.tag == "Dimples_Hands"){
            print("You have been hit");
        }
    }
}
