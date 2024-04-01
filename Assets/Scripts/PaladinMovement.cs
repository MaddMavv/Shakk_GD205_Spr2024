using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaladinMovement : MonoBehaviour
{
    public float movementSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        GetComponent<Animator>().SetFloat("Movement", move.z);
        GetComponent<CharacterController>().Move(move * movementSpeed);
    /*
        if (Input.GetKey(KeyCode.W)){
            GetComponent<Animator>().SetFloat("Movement", 1f);
        } else {
            GetComponent<Animator>().SetFloat("Movement", 1f);
        }
        */
    }
}
