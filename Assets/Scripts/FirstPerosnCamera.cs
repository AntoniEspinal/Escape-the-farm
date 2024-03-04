using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerosnCamera : MonoBehaviour
{
    public Transform player;
    public float mouseSensitivity = 2f;
    float cameraVerticalRotation = 0f;
    Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Mouse X")*mouseSensitivity;
        float inputY = Input.GetAxis("Mouse Y")*mouseSensitivity;

        cameraVerticalRotation -=inputY;
        cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90f, 90f);
        transform. localEulerAngles = Vector3.right * cameraVerticalRotation;

        player.Rotate(Vector3.up * inputX);

        if(Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit)) 
            {
                var objectHit = hit.collider.name;
                Debug.Log(objectHit);

                if(objectHit == "Safe Key")
                {
                    SafeKey safeKeyScript = hit.collider.GetComponent<SafeKey>();
                    safeKeyScript.hasSafeKey = true;
                    Destroy(hit.collider.gameObject);

                }
                // Do something with the object that was hit by the raycast.
            }
        }
        
    }
}
