using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{

    public PickUpItems pickUpItems;
    Renderer rend;
    // Start is called before the first frame update
    void Awake()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = pickUpItems.keyColor;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                pickUpItems.hasKey = true;
                Destroy(gameObject);
            }        
        }
        
    }
}
