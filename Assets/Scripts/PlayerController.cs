using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private float horizontalInput;
    private float verticalInput;
    public float jumpForce = 50;
    float speed = 8.0f;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        /*
        if (Input.GetButtonDown("up"))
        {

        }

        if (Input.GetButtonDown("down"))
        {

        }
        if (Input.GetButtonDown("left"))
        {

        }
        if (Input.GetButtonDown("right"))
        {

        }
        if (Input.GetButtonDown("jump"))
        {

        }
        */
        if (Input.GetButtonDown("Jump"))
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

    }
}
