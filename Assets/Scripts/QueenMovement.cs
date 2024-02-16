using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenMovement : MonoBehaviour
{
    public Transform hazard; 
    public Transform[] hazards;
    AudioSource deadAudioPlayer;
    public AudioClip dadAudioClip;
    Vector3 startPos;
    
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        deadAudioPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0;i < hazards.Length; i++){
            if (transform.position == hazards[i].position){
                transform.position = startPos;

                deadAudioPlayer.PlayOneShot(dadAudioClip, 0.5f);
            }
        }
        if (transform.position == hazard.position){
            Debug.Log("QUEEN IS HURT");
            transform.position = startPos;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Queen moved forwards");
            transform.position -= new Vector3(0f, 0f, 1f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Queen moved backwards");
            transform.position -= new Vector3(0f, 0f, -1f);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Queen moved left");
            transform.position -= new Vector3(-1f, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Queen moved right");
            transform.position -= new Vector3(1f, 0f, 0f);  
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Queen jumped");
            transform.position += new Vector3(0f, 1.5f, 0f);
        } 
    }
}
