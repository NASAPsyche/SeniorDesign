using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Ruler : MonoBehaviour { 
	public Text CurrentRulerLength;
	float  RScale;
	double fov;
	public Camera cam;
	//private float VestaRadius =  38,024.6km/2;
	//private float (constant to mulitply fov and radius with to make distance accurate)

//uses fov to determine scale
	void Update(){
	fov = cam.fieldOfView;
        RScale = (float)fov;
        CurrentRulerLength.text = RScale.ToString();
 	}
}