using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; // We need to add this directive at the top to gain access to the AI classes.
public class JoeNavigator : MonoBehaviour
{
    NavMeshAgent joe; // Creating a new agent in our script to manipulate.
    public Transform target; // Creating a transform to serve as our target for our agaent
    // Start is called before the first frame update
    void Start()
    {
        // Assign joe to the nevmeshagaent attached to the same game object.
        joe = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // We set the destination to take the position of the target we set in the insepctor.
       joe.destination = target.position;
    }
}
