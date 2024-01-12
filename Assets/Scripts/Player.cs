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

    bool isDoorOpen = false;
    bool isSafeDoorOpen = false;

    private Vector3 crouchScale = new Vector3(2, 1.5f, 2);
    private Vector3 playerScale = new Vector3(3, 3f, 3);

    // Start is called before the first frame update
    void Awake()
    {
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

        }else if(!isDoorOpen && pickUpKeyScript.hasKey == true)
        {
            door.OpenDoor();
            isDoorOpen = true;

        }

        if(Input.GetKeyDown(KeyCode.C))
        {
            transform.localScale = crouchScale;
            transform.position = new Vector3(transform.position.x, transform.position.y - 1.5f, transform.position.z);
        }

        if(Input.GetKeyUp(KeyCode.C))
        {
            transform.localScale = playerScale;
            transform.position = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
        }

        
    }
}
