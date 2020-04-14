using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Ruler : MonoBehaviour { 
	public Text CurrentRulerLength;
	float  RScale, cameraDistance;
	public Image uiRuler;
	public Camera cam;
	public GameObject Vesta;
	private float VestaDiameter =  530.0F;

	void Start(){
		if(cam == null){cam = Camera.main;}
	}

	void Update(){
		cameraDistance = Vector3.Distance(cam.transform.position, Vesta.transform.position);

	        RScale = VestaDiameter/(cameraDistance); 
			//width of vesta from perspective of camera
		RScale *= (uiRuler.sprite.rect.width/cam.pixelRect.width); 
			//multiplied by the percentage of screen space taken up by the ruler
	
	        CurrentRulerLength.text = RScale.ToString();
 	}
}