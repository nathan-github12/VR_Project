using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linkedCode : MonoBehaviour
{
    public static int linkedNumber;
    public int internalNumber;

    // Update is called once per frame
    void Update()
    {
        internalNumber = linkedNumber;
        
    }
}
