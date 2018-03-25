using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour {

    public GameObject projectile;
    public GameObject gun;
    //public Transform projectileParent;
    //private Animator attackerGun;
    private GameObject projectileParent;

    private void Start()
    {
        projectileParent = GameObject.Find("Projectiles");
        if (!projectileParent)
        {
            projectileParent = new GameObject("Projectiles");
        }
    }
    // Use this for initialization
    private void Fire()
    {
        GameObject newProjectileTest = Instantiate(projectile, projectileParent.transform);
        //attackerGun = gameObject.GetComponent<Animator>();
        //attackerGun.SetBool("isAttacking", true);
        newProjectileTest.transform.position = gun.transform.position;
        Debug.Log("Fire the courgette");
    }

}
