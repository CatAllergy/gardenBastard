using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {

    [Range(-1f, 1.5f)]
    private float currentSpeed;
    private GameObject currentTarget;
    private Animator animationControl;

	// Use this for initialization
	void Start () {
        //Rigidbody2D myRigidBody = gameObject.AddComponent<Rigidbody2D>();
        //myRigidBody.isKinematic = true;
        animationControl = gameObject.GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
        //print(currentTarget);
        if (!currentTarget)
        {
            animationControl.SetBool("isAttacking", false);
        }
    }
    public void SetSpeed (float speed)
    {
        currentSpeed = speed;
    }

    // Called from the animator at the time of the actual blow
    void StrikeCurrentTarget(float damage)
    {
        if (currentTarget)
        {
            //Debug.Log(name + " dealt" + damage + " damage");
            health hp = currentTarget.GetComponent<health>();
            if (hp)
            {
                hp.DealDamage(damage);
            }
        }
    }
    public void Attack (GameObject obj)
    {
        currentTarget = obj;
        //print(currentTarget);
    }

}
 