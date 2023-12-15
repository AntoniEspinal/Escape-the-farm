using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 5.0f;
    float horizontalInput;
    float forwardInput;
    private Vector3 crouchScale = new Vector3(2, 0.5f, 2);
    private Vector3 playerScale = new Vector3(3, 3f, 3);

    [SerializeField] PickUpItems[] pickUpItems;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);  

        if(Input.GetKeyDown(KeyCode.C))
        {
            transform.localScale = crouchScale;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z);
        }

        if(Input.GetKeyUp(KeyCode.C))
        {
            transform.localScale = playerScale;
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
     
        }

        foreach(PickUpItems key in pickUpItems) 
        {
            if(key.hasKey == true)
            {
                StartCoroutine(OpenDoor());
            }
        }
    }

    IEnumerator OpenDoor()
    {
        Debug.Log("Open Sesame");
        yield return new WaitForSeconds(2); 
    }

}
