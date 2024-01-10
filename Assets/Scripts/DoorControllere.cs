using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControllere : MonoBehaviour
{

    Quaternion startAngle = Quaternion.Euler(0,0,0);
    Quaternion endAngle = Quaternion.Euler(0,-90,0);
    Quaternion currentAngle;



    // Start is called before the first frame update
    void Start()
    {
        currentAngle = startAngle;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenDoor()
    {
        ChangeCurrentAngle();
        transform.rotation = Quaternion.Slerp(transform.rotation, currentAngle, 0.5f);
    }

    void ChangeCurrentAngle()
    {
        if(currentAngle.eulerAngles.y == startAngle.eulerAngles.y) 
        {
           currentAngle = endAngle;
           Debug.Log(currentAngle);
        }else 
        {   
            currentAngle = startAngle;
        }
    }
}
