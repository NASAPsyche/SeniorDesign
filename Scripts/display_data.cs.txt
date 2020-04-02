using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class display_data : MonoBehaviour
{
    // 3D Components
    public GameObject _Calpurnia;
    public GameObject _Marcia;
    public GameObject _Minucia;
    public GameObject _Caparronia;
    public GameObject _Domitia;

    // Information Panels 
    public GameObject CalpurniaIP;
    public GameObject MarciaIP;
    public GameObject MinuciaIP;
    public GameObject CaparroniaIP;
    public GameObject DomitiaIP;

    void Start()
    {
        CalpurniaIP.SetActive(false);
        MarciaIP.SetActive(false);
        MinuciaIP.SetActive(false);
        CaparroniaIP.SetActive(false);
        DomitiaIP.SetActive(false);

        _Calpurnia.SetActive(false);
        _Marcia.SetActive(false);
        _Minucia.SetActive(false);
        _Caparronia.SetActive(false);
        _Domitia.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown("h"))
        {    
            // Toggle DataPoints 
            print("h key was pressed");
            ToggleDataPoints(_Calpurnia);
            ToggleDataPoints(_Marcia);
            ToggleDataPoints(_Minucia);
            ToggleDataPoints(_Caparronia);
            ToggleDataPoints(_Domitia);
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

                    // Calpurnia Crater 
                    if (hit.transform.gameObject == _Calpurnia)
                    {
                        CalpurniaIP.SetActive(true);
                        Time.timeScale = 0f;
                    }
                    else
                    {
                        CalpurniaIP.SetActive(false);
                        Time.timeScale = 1f;
                    }
                    // Marcia Crater 
                    if (hit.transform.gameObject == _Marcia)
                    {
                        MarciaIP.SetActive(true);
                        Time.timeScale = 0f;
                    }
                    else
                    {
                        MarciaIP.SetActive(false);
                        Time.timeScale = 1f;
                    }
                    // Minucia Crater 
                    if (hit.transform.gameObject == _Minucia)
                    {
                        MinuciaIP.SetActive(true);
                        Time.timeScale = 0f;
                    }
                    else
                    {
                        MinuciaIP.SetActive(false);
                        Time.timeScale = 1f;
                    }
                    // Caparronia Crater 
                    if (hit.transform.gameObject == _Caparronia)
                    {
                        CaparroniaIP.SetActive(true);
                        Time.timeScale = 0f;
                    }
                    else
                    {
                        CaparroniaIP.SetActive(false);
                        Time.timeScale = 1f;
                    }
                    // Domitia Crater 
                    if (hit.transform.gameObject == _Domitia)
                    {
                        DomitiaIP.SetActive(true);
                        Time.timeScale = 0f;
                    }
                    else
                    {
                        DomitiaIP.SetActive(false);
                        Time.timeScale = 1f;
                    }
                }
            }
        }
    }
    // TODO: create method to not use if/else 
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
