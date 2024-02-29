using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapMovement : MonoBehaviour
{
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
      startPos = transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("OH LORD IT'S COMING");
            transform.position += new Vector3(0f, 0f, 1f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("OH LORD IT'S COMING");
            transform.position += new Vector3(0f, 0f, -1f);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("OH LORD IT'S COMING");
            transform.position += new Vector3(-1f, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("OH LORD IT'S COMING");
            transform.position += new Vector3(1f, 0f, 0f);  
        }
    }
}
