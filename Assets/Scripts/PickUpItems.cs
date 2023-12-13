using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Keys", menuName = "Create Item", order = 0)]

public class PickUpItems : ScriptableObject
{
    public string item = "New PickUpItems";
    public bool hasKey = false;
    public Color keyColor;
    

}
