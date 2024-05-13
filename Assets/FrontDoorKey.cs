using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontDoorKey : MonoBehaviour, IInteractable
{
    
    public void Interact()
    {
        GameObject.Find("Front Door").GetComponent<Animator>().SetTrigger("OpenFrontDoor");
        Destroy(gameObject);

    }
    
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
