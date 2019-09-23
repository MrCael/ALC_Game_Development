using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    public GameObject Player;
        // Start is called before the first frame update
        void Start()
        {

        }

        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "obstacle")
            {
                transform.position = new Vector3(0, 0, 0);
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            // get the user's vertical input
            verticalInput = Input.GetAxis("Vertical");

            // move the plane forward at a constant rate
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

            // tilt the plane up/down based on up/down arrow keys
            transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput);
        }
}
