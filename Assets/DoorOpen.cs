using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour, IInteractable
{
    public void Interact()
   {
    Debug.Log("Here");
    GetComponent<Animator>().SetTrigger("OpenDoor");
      
      
   }   

}
