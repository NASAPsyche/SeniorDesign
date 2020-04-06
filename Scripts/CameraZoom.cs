using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    private float X = 60f;
    private float Y = 60f;
    private float Z = 60f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            X -= 2f;
            Y -= 2f;
            Z -= 2f;
            GetComponent<Camera>().transform.position = new Vector3(X, Y, Z);
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            X += 2f;
            Y += 2f;
            Z += 2f;
            GetComponent<Camera>().transform.position = new Vector3(X, Y, Z);
        }
    }
}
