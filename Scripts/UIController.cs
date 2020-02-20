using System.Collections;

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
	//Set up a game object for the canvas and various UI elements
	public GameObject MainUI_Canvas = new GameObject();
	GameObject RulerUI = new GameObject();
	GameObject HideRuler = new GameObject();

	//Make the UI elements a child of the canvas
	RulerUI.transform.SetParent(MainUI_Canvas.transform, false);

	//I'm not sure if the UI components need to be initialized in start or not
	void Start(){
		//Initialize Ruler components
		Image rulerImg = RulerUI.AddComponent<Image>();
		Text leftzero = RulerUI.AddComponent<Text>(); //go ahead and change the name if you wish
		Text dynamicMeasure = RulerUI.AddComponent<Text>();

		//set the image's albedo color to black so that it can turn trasnparent
		var temp = rulerImg.color;
		temp.a = 0.0f;
		rulerImg.color = temp;
	}
}