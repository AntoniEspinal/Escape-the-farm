using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontDoorKey : MonoBehaviour, IInteractable
{
    public static int frontDoorKeyCount = 0;
    public void Interact()
    {
        frontDoorKeyCount++;
        Destroy(gameObject);

        if(frontDoorKeyCount >= 2)
        {
            GameObject.Find("Front Door").GetComponent<Animator>().SetTrigger("OpenFrontDoor");
        }

    }
    
}
