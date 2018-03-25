
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAgain : MonoBehaviour
{

    public GameObject projectile;
    public GameObject gun;
    public GameObject projectileParent;
    //private Animator attackerGun;
    // Use this for initialization
    private void Fire()
    {
        GameObject newProjectileTest = Instantiate(projectile, projectileParent.transform);
        //newProjectileTest.transform.parent = projectileParent.transform;
        //attackerGun = gameObject.GetComponent<Animator>();
        //attackerGun.SetBool("isAttacking", true);
        newProjectileTest.transform.position = gun.transform.position;
        Debug.Log("Fire the courgette");
    }

}