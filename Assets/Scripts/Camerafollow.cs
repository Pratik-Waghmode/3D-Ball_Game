using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public GameObject ballsphere;
    private Vector3 dist;
    // Start is called before the first frame update
    void Start()
    {
        dist = transform.position - ballsphere.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = dist + ballsphere.transform.position;
    }
}
