using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        //if the sphere collides with the game object this script is attached to, then the main scene is loaded.
        // this means that the game is restarted.
        SceneManager.LoadScene("MainScene");
    }

}
