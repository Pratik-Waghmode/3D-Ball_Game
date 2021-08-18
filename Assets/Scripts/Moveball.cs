using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Moveball : MonoBehaviour
{ // setting up the variables needed.
    Rigidbody rb;
    public int ballspeed;
    public int jumpspeed;
    private bool isGrounded;
    private int score;
    public Text coinsText;
    public AudioSource asource;
    public AudioClip aclip;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        coinsText.text = "COINS:" + score;
    }

    // Update is called once per frame
    void Update()
    {
        float Hmove = Input.GetAxis("Horizontal");// gets the horizontal input from keyboards "a and d".
        float Vmove = Input.GetAxis("Vertical"); // gets the vertical input from keyboards "w and s".

        Vector3 ballmove = new Vector3(Hmove, 0.0f, Vmove); // passing the Hmove and Vmove values in the vector3.
        rb.AddForce(ballmove * ballspeed);// here the vector3 is passed in the AddForce method.
        
        // Jumping method and checking if the object is grounded(touching the ground) or not.
        if ((Input.GetKey(KeyCode.Space)) && isGrounded) {
            Vector3 balljump = new Vector3(0.0f, 10.0f, 0.0f);
            rb.AddForce(balljump*jumpspeed);
            isGrounded = false;
        }

    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.layer == 6) // if the game object is colliding with the elements of ground layer then the isgrounded value is set to true. 
        { isGrounded = true; }
    }
    private void OnTriggerEnter(Collider other)
    {
        // checking to see if the coins are trigerred and if yes the score is added and the audio clip assigned is played.
        if (other.gameObject.CompareTag("Coinstag")) {
            other.gameObject.SetActive(false);
            score = score + 100;
            coinsText.text = "COINS:" + score;
            asource.PlayOneShot(aclip);


            if (score == 800) {
                SceneManager.LoadScene("EndScene");
            }
        }
    }

}
