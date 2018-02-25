using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour {

    public float hitpoints = 500f;

    public void DealDamage (float damage)
    {
        hitpoints -= damage;
        if(hitpoints <= 0)
        {
            DestroyDefender();
        }
    }
    public void DestroyDefender()
    {
        Destroy(gameObject);
    }
}
