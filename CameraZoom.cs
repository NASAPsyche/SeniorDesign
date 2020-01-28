using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Will need a FPSController [Standard Assets > Characters]
public class CameraZoom : MonoBehaviour
{
    public int zoomIn = 5;
    public int zoomOut = 5;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            GetComponent<Camera>().fieldOfView -= zoomIn;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            GetComponent<Camera>().fieldOfView += zoomOut;
        }
    }
}
