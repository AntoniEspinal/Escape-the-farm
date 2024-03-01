using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeKey : MonoBehaviour
{
    public GameObject safeKeyObject;
    
    public bool hasSafeKey = false;
    
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
        if (Input.GetKey(KeyCode.E))
        {
            hasSafeKey = true;
            this.gameObject.SetActive(false);
           
            
        }
    }




}
