using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Ruler : MonoBehaviour { 
	public Text CurrentRulerLength;
	float  RScale, screenDiameter, pixelSize, distance;
	public RectTransform uiRuler;
	public Camera cam;
	public GameObject Vesta;
	public float VestaDiameter;

	void Start(){
		if(VestaDiameter == 0){VestaDiameter =  530.0F; Debug.Log(VestaDiameter);}
		if(cam == null){cam = Camera.main;}
	
		screenDiameter = Vesta.transform.GetComponentInChildren<Renderer>().bounds.extents.magnitude;
		screenDiameter -= Vector3.Distance(Vesta.transform.position, Vector3.zero);
	}

	void Update(){
		distance = Vector3.Distance(Vesta.transform.position, cam.transform.position);
		pixelSize = (screenDiameter * Mathf.Rad2Deg * Screen.height) / (distance * cam.fieldOfView);
	        RScale = VestaDiameter*(pixelSize/uiRuler.sizeDelta.x);

		Debug.Log(pixelSize+","+screenDiameter);
	        CurrentRulerLength.text = RScale.ToString();
 	}
}