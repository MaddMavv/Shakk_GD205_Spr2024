using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cyclops : MonoBehaviour
{
   public float explosionForce = 5f;
   public float explosionRadius = 20f;
   public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();
        
        if(Physics.Raycast(laser, out hit) && Input.GetMouseButton(0)){
            Debug.Log("booyah, cyclops sucks!");
            if (hit.rigidbody){
                hit.rigidbody.AddExplosionForce(explosionForce, hit.point, explosionRadius);
            }
        }

        if(Physics.Raycast(laser, out hit) && Input.GetMouseButton(1)){  
            Instantiate(prefab, hit.point, Quaternion.identity);
        }
    }
}
