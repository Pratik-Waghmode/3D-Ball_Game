using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changescene() {
        
        SceneManager.LoadScene("MainScene");   
      
    }
    public void exitgame()
    {
        Debug.Log("u pressed the exit button");
        Application.Quit();
    }
}
