using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent (typeof (Attacker))]

public class lizard : MonoBehaviour
{
    
    private Animator lizAnimator;
    private Attacker attacker;
    // Use this for initialization
    void Start()
    {
        lizAnimator = gameObject.GetComponent<Animator>();
        attacker = GetComponent<Attacker>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        GameObject obj = collision.gameObject;
        //print(obj);
        if (!obj.GetComponent<Defenders>())
        {
            return;
        }
        
        lizAnimator.SetBool("isAttacking", true);
        attacker.Attack(obj);
     
        //Debug.Log("Fox hit " + collision);
    }
}