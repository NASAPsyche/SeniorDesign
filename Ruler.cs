using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruler : MonoBehaviour { 
	public text CurrentRulerLength;
	private float  RScale;
	//private float VestaRadius =  38,024.6km/2;
	//private float (constant to mulitply fov and radius with to make distance accurate)

//uses fov to determine scale
	void Update()
    {
	RScale = GetComponent<Camera>().fieldOfView; 
	//multiply Rscale by a constant that will change 
    }

}