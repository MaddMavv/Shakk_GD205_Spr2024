using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    Rigidbody rb2;
    public Transform target;
    public float forceMultiplier = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetDistance = target.position - transform.position;
        Vector3 targetDirection = Vector3.Normalize(targetDistance);
        rb2.AddForce(targetDirection * forceMultiplier);
    }
    void OnCollisionEnter(Collision col){
        Destroy(gameObject);
    }
}
