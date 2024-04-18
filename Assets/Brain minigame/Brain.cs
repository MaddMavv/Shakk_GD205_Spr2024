using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : MonoBehaviour
{
    public Transform hazard; 
    public Transform[] hazards;
    Rigidbody jiggy;
    // Start is called before the first frame update
    void Start()
    {
        jiggy = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         for (int i = 0;i < hazards.Length; i++){
            if (transform.position == hazards[i].position){
                Destroy(gameObject);
            }
        }
    }
}
