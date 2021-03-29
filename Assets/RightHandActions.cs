using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHandActions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col){
        switch(col.gameObject.tag){
            case "Opponent":
                print("You have hit the opponent");
                break;
        }
    }
}
