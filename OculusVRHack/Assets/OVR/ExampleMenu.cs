using UnityEngine;
using System.Collections;

public class ExampleMenu : VRGUI 
{
	public GUISkin skin;

	private bool Q1 = true; 
	private bool Q2 = false; 
	private bool Q3 = false;
	private bool Q4 = false; 
	private bool pressed = false;
	
	public override void OnVRGUI()
	{
		if (pressed) { pressed = false; return; }
		if(Q1) 
		{
			GUI.Box(new Rect(10,10,Screen.width,Screen.height/2), "Question 1: ");
			// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
			GUI.Button(new Rect( (Screen.width/2)-20 , (Screen.height/8) , 80,20), "Z"); 
			GUI.Button(new Rect( (Screen.width/2)-20 , (Screen.height/8)+35 , 80,20), "X"); 
			GUI.Button(new Rect( (Screen.width/2)-20 , (Screen.height/8)+65 , 80,20), "C"); 
			GUI.Button(new Rect( (Screen.width/2)-20 , (Screen.height/8)+95 , 80,20), "V"); 
			if (Input.GetKeyUp(KeyCode.Z)) {
				Debug.Log("Pressed Button Z");
				pressed = true;
				Q1 = false; 
				Q2 = true;
			}
			else if (Input.GetKeyUp(KeyCode.X)) {
				Debug.Log("Pressed Button X");
				pressed = true;
				Q1 = false; 
				Q2 = true;
			}
			else if (Input.GetKeyUp(KeyCode.C)) {
				Debug.Log("Pressed Button C");
				pressed = true;
				Q1 = false; 
				Q2 = true;
			}
			else if (Input.GetKeyUp(KeyCode.V)) {
				Debug.Log("Pressed Button V");
				pressed = true;
				Q1 = false; 
				Q2 = true;
			}
		}

		else if(Q2)
		{
			GUI.Box(new Rect(10,10,Screen.width,Screen.height/2), "Question 2: ");
			// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
			GUI.Button(new Rect( (Screen.width/2)-20 , (Screen.height/8) , 80,20), "Z"); 
			GUI.Button(new Rect( (Screen.width/2)-20 , (Screen.height/8)+35 , 80,20), "X"); 
			GUI.Button(new Rect( (Screen.width/2)-20 , (Screen.height/8)+65 , 80,20), "C"); 
			GUI.Button(new Rect( (Screen.width/2)-20 , (Screen.height/8)+95 , 80,20), "V"); 
			if (Input.GetKeyUp(KeyCode.Z)) {
				Debug.Log("Pressed Button Z");
				pressed = true;
				Q2 = false; 
				Q3 = true;
			}
			else if (Input.GetKeyUp(KeyCode.X)) {
				Debug.Log("Pressed Button X");
				pressed = true;
				Q2 = false; 
				Q3 = true;
			}
			else if (Input.GetKeyUp(KeyCode.C)) {
				Debug.Log("Pressed Button C");
				pressed = true;
				Q2 = false; 
				Q3 = true;
			}
			else if (Input.GetKeyUp(KeyCode.V)) {
				Debug.Log("Pressed Button V");
				pressed = true;
				Q2 = false; 
				Q3 = true;
			}
		}

		else if (Q3) { 
			GUI.Box(new Rect(10,10,Screen.width,Screen.height/2), "Question 3: ");
			// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
			GUI.Button(new Rect( (Screen.width/2)-20 , (Screen.height/8) , 80,20), "Z"); 
			GUI.Button(new Rect( (Screen.width/2)-20 , (Screen.height/8)+35 , 80,20), "X"); 
			GUI.Button(new Rect( (Screen.width/2)-20 , (Screen.height/8)+65 , 80,20), "C"); 
			GUI.Button(new Rect( (Screen.width/2)-20 , (Screen.height/8)+95 , 80,20), "V"); 
			if (Input.GetKeyUp(KeyCode.Z)) {
				Debug.Log("Pressed Button Z");
				pressed = true;
				Q3 = false; 
				Q4 = true;
			}
			else if (Input.GetKeyUp(KeyCode.X)) {
				Debug.Log("Pressed Button X");
				pressed = true;
				Q3 = false; 
				Q4 = true;
			}
			else if (Input.GetKeyUp(KeyCode.C)) {
				Debug.Log("Pressed Button C");
				pressed = true;
				Q3 = false; 
				Q4 = true;
			}
			else if (Input.GetKeyUp(KeyCode.V)) {
				Debug.Log("Pressed Button V");
				pressed = true;
				Q3 = false; 
				Q4 = true;
			}
		}

		else if (Q4)// && OnlyOnce) { 
		{
			GUI.Box(new Rect(10,10,Screen.width,Screen.height/2), "Question 4: ");
			// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
			GUI.Button(new Rect( (Screen.width/2)-20 , (Screen.height/8) , 80,20), "Z"); 
			GUI.Button(new Rect( (Screen.width/2)-20 , (Screen.height/8)+35 , 80,20), "X"); 
			GUI.Button(new Rect( (Screen.width/2)-20 , (Screen.height/8)+65 , 80,20), "C"); 
			GUI.Button(new Rect( (Screen.width/2)-20 , (Screen.height/8)+95 , 80,20), "V"); 
			if (Input.GetKeyUp(KeyCode.Z)) {
				Debug.Log("Pressed Button Z");
				pressed = true;
				Q4 = false; 
			}
			else if (Input.GetKeyUp(KeyCode.X)) {
				Debug.Log("Pressed Button X");
				pressed = true;
				Q4 = false; 
			}
			else if (Input.GetKeyUp(KeyCode.C)) {
				Debug.Log("Pressed Button C");
				pressed = true;
				Q4 = false; 
			}
			else if (Input.GetKeyUp(KeyCode.V)) {
				Debug.Log("Pressed Button V");
				pressed = true;
				Q4 = false; 
			}
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
			Application.Quit();
	}
}
