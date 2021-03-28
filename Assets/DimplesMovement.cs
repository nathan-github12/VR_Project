using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimplesMovement : MonoBehaviour
{
    public Animator animator;
    public CharacterController2D controller;
    Animator animator = playerTransform.gameObject.GetComponent<Animator>();
    animator.runtimeAnimatorController = Resources.Load("path_to_your_controller") as RuntimeAnimatorController;
        
    // Start is called before the first frame update
    //void Start()
    {
        //
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
