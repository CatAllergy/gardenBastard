using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {

    [Range(-1f, 1.5f)]
    private float currentSpeed;
    private GameObject currentTarget;

	// Use this for initialization
	void Start () {
        //Rigidbody2D myRigidBody = gameObject.AddComponent<Rigidbody2D>();
        //myRigidBody.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
        print(currentTarget);
	}
    public void SetSpeed (float speed)
    {
        currentSpeed = speed;
    }
    void StrikeCurrentTarget(float damage)
    {
        //Debug.Log(name + " dealt" + damage + " damage");

    }
    public void Attack (GameObject obj)
    {
        currentTarget = obj;
        //print(currentTarget);
    }

}
 