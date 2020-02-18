using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snap : MonoBehaviour
{
    Vector3 _rotation = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");

            float degrees = 90;
            Vector3 to = new Vector3(degrees, 0, 0);

            transform.rotation = Quaternion.Euler(0, 85, -25);
        }
    }
}
