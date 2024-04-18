using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thoughts : MonoBehaviour
{
    Rigidbody getem;
    public Transform target;
    public float speed = 0.5f;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        getem = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetDistance = target.position - transform.position;
        Vector3 targetDirection = Vector3.Normalize(targetDistance);
        getem.AddForce(targetDirection * speed);

        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();
        
        if(Physics.Raycast(laser, out hit)){
            Debug.Log("booyah, cyclops sucks!");
            if (hit.rigidbody){
                transform.position = startPos;
            }
        }
    }
}
