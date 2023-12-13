using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{
    public GameObject KeyOnPlayer;
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
            if (Input.GetKeyDown(KeyCode.P))
            {
                Destroy(other.gameObject);

                KeyOnPlayer.SetActive(true);
            }        
        }
        
    }
}
