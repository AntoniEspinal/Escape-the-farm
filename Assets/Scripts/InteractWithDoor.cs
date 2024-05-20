using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithDoor : MonoBehaviour, IInteractable
{

    public string animationName;
    public void Interact()
   {
      GetComponent<Animator>().SetTrigger(animationName);
      
   }   
}
