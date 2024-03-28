using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody playerRb;


    private Vector3 crouchScale = new Vector3(2, 1.5f, 2);
    private Vector3 playerScale = new Vector3(3, 3f, 3);

    

    // Start is called before the first frame update
    void Awake()
    {
       
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
        // if(Input.GetKeyDown(KeyCode.C))
        // {
        //     transform.localScale = crouchScale;
        //     transform.position = new Vector3(transform.position.x, transform.position.y - 1.5f, transform.position.z);
        // }

        // if(Input.GetKeyUp(KeyCode.C))
        // {
        //     transform.localScale = playerScale;
        //     transform.position = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
        // }
    }
}
