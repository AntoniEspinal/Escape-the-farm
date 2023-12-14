using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{
    public GameObject KeyWithPlayer;
    public PickUpItems pickUpItems;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(other.gameObject);

                KeyWithPlayer.SetActive(true);
            }        
        }
        
    }
}
