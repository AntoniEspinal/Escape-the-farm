using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{
    public GameObject Key;
    // Start is called before the first frame update
    void Start()
    {
        Key.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStaY(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            this.gameObject.SetActive(false);
            Key.SetActive(true);
        }
    }
}
