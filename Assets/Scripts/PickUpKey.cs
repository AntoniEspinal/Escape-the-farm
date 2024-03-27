using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour, IInteractable
{
    public GameObject levelTrigger;
   public void Interact()
   {
    levelTrigger.SetActive(true);
    GameObject.Find("Door Hinge").GetComponent<Animator>().SetTrigger("OpenDoor");
      Destroy(gameObject);


   }

}
