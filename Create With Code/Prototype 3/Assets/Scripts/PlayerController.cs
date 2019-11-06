using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool canJump = true;

    // Start is called before the first frame update
    void Start()
    {
        playerRb.GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if (canJump == true)
            {
                playerRb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
                canJump = false;
            }
        }
    }
}
