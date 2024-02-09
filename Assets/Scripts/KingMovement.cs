using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingMovement : MonoBehaviour
{
    public Transform hazard; 
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == hazard.position){
            Debug.Log("HAZARD OUCH");
            transform.position = startPos;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("w key was pressed");
            transform.position += new Vector3(0f, 0f, 1f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("s key was pressed");
            transform.position += new Vector3(0f, 0f, -1f);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("a key was pressed");
            transform.position += new Vector3(-1f, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("d key was pressed");
            transform.position += new Vector3(1f, 0f, 0f);  
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space key was pressed");
            transform.position += new Vector3(0f, 1.5f, 0f);
        }
    }
}
