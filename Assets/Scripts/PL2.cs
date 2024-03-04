using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PL2 : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 5.0f;
    float horizontalInput;
    float forwardInput;

    private Vector3 crouchScale = new Vector3(2, 1.5f, 2);
    private Vector3 playerScale = new Vector3(3, 3f, 3);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerRb = GetComponent<Rigidbody>();

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

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
