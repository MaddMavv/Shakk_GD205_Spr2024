using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIstuff : MonoBehaviour
{
    public GameObject pauseMenu;
    
    public TMP_InputField input;
    void Update(){
        if (Input.GetKeyUp(KeyCode.Escape)){
            pauseMenu.SetActive(!pauseMenu.active);
        }
    }
    public void Quit(){
        Application.Quit();
    }
    public void ChangeScene(){
        
        SceneManager.LoadScene(int.Parse(input.text));
    }
}
