using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayData : MonoBehaviour
{
    // 3D Components, Information Panels, Compass
    public GameObject[] Craters;
    public GameObject[] InformationPanels;
    public GameObject Compass;

    void Start()
    {
        // DataPoints(Craters), Information Panels, Compass, are hidden at start
        foreach (GameObject crater in Craters)
        {
            crater.SetActive(false);
        }
        foreach (GameObject infoPanel in InformationPanels)
        {
            infoPanel.SetActive(false);
        }
        Compass.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown("h"))
        {
            print("h key was pressed");

            // Toggle DataPoints & Compass
            foreach (GameObject crater in Craters)
            {
                ToggleObjects(crater);
            }
            ToggleObjects(Compass);
        }
        if (Input.GetMouseButtonDown(1)) 
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform != null)
                {
                    PrintName(hit.transform.gameObject);

                    // Hide or show information panels
                    for (int i = 0; i < Craters.Length; i++)
                    {
                        if (hit.transform.gameObject == Craters[i])
                        {
                            InformationPanels[i].SetActive(true);
                            Craters[i].GetComponent<Renderer>().material.color = Color.yellow;
                        }
                        else
                        {
                            InformationPanels[i].SetActive(false);
                            Craters[i].GetComponent<Renderer>().material.color = Color.white;
                        }
                    }
                }
            }
        }
    }

    private void PrintName(GameObject go)
    {
        print(go.name);
    }

    private void ToggleObjects(GameObject game_obj)
    {
        if (game_obj.activeSelf == true)
        {
            game_obj.SetActive(false);
        }
        else
        {
            game_obj.SetActive(true);
        }
    }
}