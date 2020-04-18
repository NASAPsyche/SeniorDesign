using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Ruler : MonoBehaviour { 
	float  screenDiameter, RScale, RLength, distance;
	public Text CurrentRulerLength;
	public RectTransform uiRuler;
	public Camera cam;
	public GameObject Vesta;
	public float VestaDiameter;

	void Start(){
		if(VestaDiameter == 0){VestaDiameter =  530.0F; Debug.Log(VestaDiameter);}
		if(cam == null){cam = Camera.main;}

		screenDiameter = Vesta.transform.GetComponentInChildren<Renderer>().bounds.extents.magnitude;
		RLength = uiRuler.sizeDelta.x;
		RScale = VestaDiameter*(screenDiameter/RLength);

	}

	void Update(){
		distance = Vector3.Distance(Vesta.transform.position, cam.transform.position);
		RScale = (screenDiameter * Mathf.Rad2Deg * Screen.height) /(distance * cam.fieldOfView);
		RScale = VestaDiameter * RLength/RScale;  
	        CurrentRulerLength.text = RScale.ToString();

		Debug.Log(screenDiameter+", "+distance+", "+RScale);
	}

//pieces of alternate solutions

//virtualRadius = Vesta.transform.GetComponentInChildren<Renderer>().bounds.size.magnitude;virtualRadius -= Vector3.Distance(Vesta.transform.position, Vector3.zero);virtualRadius = virtualRadius/2;VestaCenter = Vesta.transform.GetComponentInChildren<Mesh>().bounds.center;VestaHorizon = virtualRadius/distance * Mathf.Sqrt(distance*distance - virtualRadius*virtualRadius);distance = Mathf.Sqrt(distance*distance - virtualRadius*virtualRadius);VestaHorizon *= distance;pixelWidth = (virtualRadius*2 * VestaHorizon) / (distance * Mathf.Tan(cam.fieldOfView*Mathf.Deg2Rad));
//float computeProjectedRadius(float d, float r) {float fov;fov = cam.fieldOfView / 2.0f * Mathf.PI / 180.0f;return 1.0f/Mathf.Tan(fov) * r / Mathf.Sqrt(d * d - r * r);}
//Northpole = Vesta.transform.GetComponentInChildren<Renderer>().bounds.max;Southpole = Vesta.transform.GetComponentInChildren<Renderer>().bounds.extents;undo = Quaternion.Inverse(Vesta.transform.rotation);undo = Quaternion.Euler(rotation.x,rotation.y,rotation.z);Northpole.Set(0,Southpole.magnitude,0);Southpole.Set(0,-Southpole.magnitude,0);Southpole = Vector3.RotateTowards(Southpole, , Mathf.Infinity, 0.0f);Southpole = undo * Southpole;m = Matrix4x4.TRS(Vector3.zero, undo, Vector3.one);m.MultiplyPoint3x4(Southpole);pixelLength = Vector3.Distance(cam.WorldToScreenPoint(Northpole),cam.WorldToScreenPoint(Southpole));
		//VestaEdges = Vesta.transform.GetComponentInChildren<MeshFilter>().mesh.vertices;for(var i = 0; i < VestaEdges.Length; i++){screenRadius += Vector3.Distance(cam.WorldToViewportPoint(VestaEdges[i]), cam.WorldToViewportPoint(Vesta.transform.position));}screenRadius = screenRadius/VestaEdges.Length;

}
