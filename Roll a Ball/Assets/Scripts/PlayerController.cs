using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    //Global Variables
    public float speed;
    public Text countText;
    public Text winText;

    //Private Variables
    private Rigidbody rb;
    private int count;
    void Start ()
    {
        //Setting the count
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText ();
        winText.text = "";
    } 
   
    void FixedUpdate ()
    //Controls for the horizontal and vertical axis. Controls the movement speed of the ball as well. 
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);
    }

    //This is the logic behind picking up items and incrementing the count as you set them to be out of view. 
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive (false);
            count = count + 1;
           SetCountText ();
        }
   }

    //This is the label that shows up once you have won the game. 
    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            winText.text = "Awesome! Great job!";
        }
    }
}