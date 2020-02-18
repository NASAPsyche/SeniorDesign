using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerrainSwitch : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            print("s key was pressed");
            SceneManager.LoadScene("SampleScene");

        }
        if (Input.GetKeyDown("e"))
        {
            print("e key was pressed");
            SceneManager.LoadScene("Asteroide");

        }
        if (Input.GetKeyDown("i"))
        {
            print("i key was pressed");
            SceneManager.LoadScene("Asteroidi");

        }
    }
}
