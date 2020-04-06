using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class display_data : MonoBehaviour
{
    // 3D Components & Information Panels
    public GameObject[] Craters;
    public GameObject[] InformationPanels;

    void Start()
    {
        foreach (GameObject crater in Craters)
        {
            crater.SetActive(false);
        }
        foreach (GameObject infoPanel in InformationPanels)
        {
            infoPanel.SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown("h"))
        {
            // Toggle DataPoints 
            print("h key was pressed");

            foreach (GameObject crater in Craters)
            {
                ToggleDataPoints(crater);
            }
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

    private void ToggleDataPoints(GameObject game_obj)
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