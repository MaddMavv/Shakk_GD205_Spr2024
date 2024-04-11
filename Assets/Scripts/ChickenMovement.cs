using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class ChickenMovement : MonoBehaviour
{
    Rigidbody rb;
    public float acc = 0.5f;
    Vector2 move;
    float hInput;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal");

        move = new Vector2(hInput, 0);

        rb.AddForce(move * acc);

        if(Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce(Vector2.up * 5.0f, ForceMode.Impulse);
        }

        /*if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("OH LORD IT'S COMING");
            rb.AddForce(-acc, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("OH LORD IT'S COMING");
            rb.AddForce(acc, 0f, 0f);  
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("OH LORD IT'S COMING");
            rb.AddForce(0f, acc, 0f);  
        }*/
    }
}
