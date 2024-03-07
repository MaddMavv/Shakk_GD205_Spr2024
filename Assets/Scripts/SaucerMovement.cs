using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaucerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float acc = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Fixed Update is called once per standard interval instead of per frame
    void FixedUpdate()
    {
      rb.AddForce(0f, 0f, 1f);  
    
      {
        if (Input.GetKey(KeyCode.W)){
            Debug.Log("UFO moved foward");
            rb.AddForce(0f, 0f, acc);
        }
        if (Input.GetKey(KeyCode.A)){
            Debug.Log("UFO moved left");
            rb.AddForce(-acc, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D)){
            Debug.Log("UFO moved right");
            rb.AddForce(acc, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S)){
            Debug.Log("UFO moved backwards");
            rb.AddForce(0f, 0f, -acc);
        }
        if (Input.GetKey(KeyCode.E)){
            Debug.Log("UFO moved up");
            rb.AddForce(0f, acc, 0f);
        }
        if (Input.GetKey(KeyCode.Q)){
            Debug.Log("UFO moved ");
            rb.AddForce(0f, -acc, 0f);
        }
      }
    }
}
