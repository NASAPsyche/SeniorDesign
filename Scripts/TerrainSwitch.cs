using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerrainSwitch : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            print("t key was pressed");
            SceneManager.LoadScene("SampleScene");

        }

    }
}
