using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool Punch = false;
    private Animator animator;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        //animator = GetComponentInChildren<Animataor>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target!=null){
           transform.LookAt(target);
       } 
        //if (playerAttack){
            //animator.SetBool("Punch", true);
       //}else{
        //    animator.SetBool("Punch", false);
        //}
        
    }
    //public void Attack(){
    // //   playerAttack = true;
    //}

    //public void Defend(){
      //  playerDefend = true;
//
    //}

}
