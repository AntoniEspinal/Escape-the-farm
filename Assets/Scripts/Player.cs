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
    SafeKey safeKeyScript;
    DoorControllere door; 
    SafeDoorController safeDoor;

    bool isDoorOpen = false;
    bool isSafeDoorOpen = false;

    // Start is called before the first frame update
    void Awake()
    {
        safeDoor = GameObject.Find("Safe Door Hinge").GetComponent<SafeDoorController>();
        door = GameObject.Find("Door Hinge").GetComponent<DoorControllere>();
        pickUpKeyScript = GameObject.Find("Key").GetComponent<PickUpKey>();
        safeKeyScript = GameObject.Find("Safe Key").GetComponent<SafeKey>();
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        if(!isDoorOpen && pickUpKeyScript.hasKey == true)
        {
            door.OpenDoor();
            isDoorOpen = true;

        }else if(!isSafeDoorOpen && safeKeyScript.hasSafeKey == true)
        {
            safeDoor.OpenSafeDoor();
            isSafeDoorOpen = true;

        }
       
        
    }
}
