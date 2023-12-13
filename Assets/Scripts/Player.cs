using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 5.0f;
    float horizontalInput;
    float forwardInput;

    PickUpKey pickUpKeyScript;
    DoorControllere door; 
    // Start is called before the first frame update
    void Start()
    {
        door = GameObject.Find("Door Hinge").GetComponent<DoorControllere>();
        pickUpKeyScript = GameObject.Find("Key").GetComponent<PickUpKey>();
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        if(pickUpKeyScript.hasKey == true)
        {
            door.OpenDoor();
        }
       
        
    }
}
