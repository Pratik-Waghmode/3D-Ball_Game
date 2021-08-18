using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{

    Vector3 turncoins;

   
    void Update()
    {
        // using the transform property of the game object(coins) to make it rotate. 
        turncoins = new Vector3(0, 0, 450);
        transform.Rotate(turncoins*Time.deltaTime);
    }
}
