using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{
    public GameObject KeyOnPlayer;
    // Start is called before the first frame update
    void Start()
    {
        KeyOnPlayer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                this.gameObject.SetActive(false);

                KeyOnPlayer.SetActive(true);
            }        
        }
        
    }
}
