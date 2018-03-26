
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAgain : MonoBehaviour
{

    public GameObject projectile;
    public GameObject gun;
    private Animator animator;
    private Spawner myLaneSpawner;
    private Attacker laneAttacker;

    //private Animator attackerGun;
    // Use this for initialization
    private GameObject projectileParent;

    private void Start()
    {
        animator = GetComponent<Animator>();
        //creates a parent if necessary to keep the project file tidy
        projectileParent = GameObject.Find("Projectiles");
        if (!projectileParent)
        {
            projectileParent = new GameObject("Projectiles");
        }
        setMyLaneSpawner();
        print(myLaneSpawner);
    }
    private void Update()
    {
        //isAttackerAheadInLand();
        print(name + laneAttacker);
        //
        if (isAttackerAheadInLand())
        {
            animator.SetBool("isAttacking", true);
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
        //
    }

    bool isAttackerAheadInLand()
    {
        //Exit if no attackers in lane
        if(myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        //if there are attackers, are they ahead?
        foreach(Transform attacker in myLaneSpawner.transform)
        {
            if (attacker.transform.position.x > transform.position.x)
            {
                return true;
            }
        }
        return false;
    }

    //Look through all the lane spawners and set myLaneSpawner if found.
    void setMyLaneSpawner()
    {
        Spawner[] spawners = GameObject.FindObjectsOfType<Spawner>();
        foreach (Spawner spawner in spawners)
            {
            if (spawner.transform.position.y == transform.position.y)
            {
            myLaneSpawner = spawner;
            return;
            }
        }
        Debug.LogError(name + " can't find spawner in lane");
    }
    private void Fire()
    {
        GameObject newProjectileTest = Instantiate(projectile, projectileParent.transform);
        //newProjectileTest.transform.parent = projectileParent.transform;
        //attackerGun = gameObject.GetComponent<Animator>();
        //attackerGun.SetBool("isAttacking", true);
        newProjectileTest.transform.position = gun.transform.position;
        //Debug.Log("Fire the courgette");
    }
}