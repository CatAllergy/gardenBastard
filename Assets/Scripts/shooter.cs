using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour {

    public GameObject projectile;
    public GameObject gun;
    private GameObject projectileParent;

    private Animator animator;
    private Spawner myLaneSpawner;

    private void Start()
    {
        Animator animator = GetComponent<Animator>();
        projectileParent = GameObject.Find("Projectiles");
        if (!projectileParent)
        {
            projectileParent = new GameObject("Projectiles");
        }
        setMyLaneSpawner();
        print (myLaneSpawner);
    }
    //Look through all the lane spawners and set myLaneSpawner if found.
    void setMyLaneSpawner()
    {
        Spawner[] spawners = GameObject.FindObjectsOfType<Spawner>();
        print(spawners);
        print(transform.position.y);
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
 

    // Use this for initialization
    private void Fire()
    {
        GameObject newProjectileTest = Instantiate(projectile, projectileParent.transform);
        newProjectileTest.transform.position = gun.transform.position;
        Debug.Log("Fire the courgette");
    }

}
