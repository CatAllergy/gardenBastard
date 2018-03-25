using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float speed, damage;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Attacker attacker = collision.gameObject.GetComponent<Attacker>();
        health healh = collision.gameObject.GetComponent<health>();

        if (attacker && healh)
        {
            healh.DealDamage(damage);
            Destroy(gameObject);
        }
    }
    /*void OnTriggerEnter2D(Collider2D collision)
    {

        GameObject obj = collision.gameObject;
        //print(obj);
        if (obj.GetComponent<Attacker>())
        {
            //foxAnimator.SetBool("isAttacking", true);
            //
            print("Projectile hit " + obj);
        }
   
        else
        {
            return;
        }
    }
    */
}
