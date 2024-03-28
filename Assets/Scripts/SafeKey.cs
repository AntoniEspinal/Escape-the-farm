using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeKey : MonoBehaviour, IInteractable
{
    public void Interact()
   {
      GameObject.Find("Safe Door Hinge").GetComponent<Animator>().SetTrigger("OpenDoor");
      Destroy(gameObject);
   }   
    



}
