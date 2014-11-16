//1. Favorite Color?
//	Black - Dom Hobbs
//		Blue - brian ludacris roman
//		Purple - Mia
//		Silver - letty
//		
//		2. Favorite type of car?
//		Mini cooper - uhh...wrong answer....lol
//		Muscle - Dom Hobbs letty
//		Import - brian, mia
//		Luxury - roman ludacris
//		
//		3. What would you do if you see flashing lights in your mirror?
//			Keep driving - dom brian letty
//				Pull over then driver away as they get close to your door - roman 		ludacris
//				You don't get pulled over cause you're the one pulling them over - 		hobbs 
//				You don't drive much so they don't appear in your mirror - mia
//				
//				4. What would you be like if one of your close friends is in the emergency room?
//					Cry your heart out - mia 
//						Sad but still comfort other people - mia dom brian
//						Most anxious person in the room - roman ludacris hobbs
//						Rage at whatever caused the incident - letty

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
	private bool result = false;

	private int brian = 0; 
	private int dom = 0; 
	private int hobbs = 0; 
	private int letty = 0;
	
	public override void OnVRGUI()
	{
		if (pressed) { pressed = false; return; }
		if(Q1) 
		{
			GUI.Box(new Rect(10,10,Screen.width,Screen.height/2), "Question 1: What is your favorite color?");
			// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
			GUI.Button(new Rect( (Screen.width/2)-80 , (Screen.height/8) , 200,20), "Black"); 
			GUI.Button(new Rect( (Screen.width/2)-80 , (Screen.height/8)+35 , 200,20), "Blue"); 
			GUI.Button(new Rect( (Screen.width/2)-80 , (Screen.height/8)+65 , 200,20), "Purple"); 
			GUI.Button(new Rect( (Screen.width/2)-80 , (Screen.height/8)+95 , 200,20), "Silver"); 
			if (Input.GetKeyUp(KeyCode.Z)) {
				Debug.Log("Pressed Button Z");
				dom++;
				pressed = true;
				Q1 = false; 
				Q2 = true;
			}
			else if (Input.GetKeyUp(KeyCode.X)) {
				Debug.Log("Pressed Button X");
				hobbs++;
				pressed = true;
				Q1 = false; 
				Q2 = true;
			}
			else if (Input.GetKeyUp(KeyCode.C)) {
				Debug.Log("Pressed Button C");
				letty++;
				pressed = true;
				Q1 = false; 
				Q2 = true;
			}
			else if (Input.GetKeyUp(KeyCode.V)) {
				Debug.Log("Pressed Button V");
				brian++;
				pressed = true;
				Q1 = false; 
				Q2 = true;
			}
		}

		else if(Q2)
		{
			GUI.Box(new Rect(10,10,Screen.width,Screen.height/2), "Question 2: Favorite type of car?");
			// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
			GUI.Button(new Rect( (Screen.width/2)-80 , (Screen.height/8) , 200,20), "Mini Cooper"); 
			GUI.Button(new Rect( (Screen.width/2)-80 , (Screen.height/8)+35 , 200,20), "Muscle"); 
			GUI.Button(new Rect( (Screen.width/2)-80 , (Screen.height/8)+65 , 200,20), "Import"); 
			GUI.Button(new Rect( (Screen.width/2)-80 , (Screen.height/8)+95 , 200,20), "Luxury"); 
			if (Input.GetKeyUp(KeyCode.Z)) {
				Debug.Log("Pressed Button Z");
				pressed = true;
				Q2 = false; 
				Q3 = true;
			}
			else if (Input.GetKeyUp(KeyCode.X)) {
				Debug.Log("Pressed Button X");
				dom++; 
				hobbs++;
				pressed = true;
				Q2 = false; 
				Q3 = true;
			}
			else if (Input.GetKeyUp(KeyCode.C)) {
				Debug.Log("Pressed Button C");
				letty++; 
				brian++;
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
			GUI.Box(new Rect(10,10,Screen.width,Screen.height/2), "Question 3: What would you do if you see flashing lights in your mirror?");
			// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
			GUI.Button(new Rect( (Screen.width/2)-150 , (Screen.height/8) , 350,20), "Pull over then driver away as they get close to your door."); 
			GUI.Button(new Rect( (Screen.width/2)-150 , (Screen.height/8)+35 , 350,20), "Keep driving."); 
			GUI.Button(new Rect( (Screen.width/2)-150 , (Screen.height/8)+65 , 350,20), "You're the one pulling THEM over."); 
			GUI.Button(new Rect( (Screen.width/2)-150 , (Screen.height/8)+95 , 350,20), "You don't drive much so they don't appear in your mirror."); 
			if (Input.GetKeyUp(KeyCode.Z)) {
				Debug.Log("Pressed Button Z");
				brian++;
				pressed = true;
				Q3 = false; 
				Q4 = true;
			}
			else if (Input.GetKeyUp(KeyCode.X)) {
				Debug.Log("Pressed Button X");
				dom++;
				pressed = true;
				Q3 = false; 
				Q4 = true;
			}
			else if (Input.GetKeyUp(KeyCode.C)) {
				Debug.Log("Pressed Button C");
				hobbs++;
				pressed = true;
				Q3 = false; 
				Q4 = true;
			}
			else if (Input.GetKeyUp(KeyCode.V)) {
				Debug.Log("Pressed Button V");
				letty++;
				pressed = true;
				Q3 = false; 
				Q4 = true;
			}
		}

		else if (Q4)// && OnlyOnce) { 
		{
			GUI.Box(new Rect(10,10,Screen.width,Screen.height/2), "Question 4: at would you be like if one of your close friends is in the emergency room?");
			// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
			GUI.Button(new Rect( (Screen.width/2)-150 , (Screen.height/8) , 350,20), "Cry your heart out."); 
			GUI.Button(new Rect( (Screen.width/2)-150 , (Screen.height/8)+35 , 350,20), "Sad but still comfort other people."); 
			GUI.Button(new Rect( (Screen.width/2)-150 , (Screen.height/8)+65 , 350,20), "Most anxious person in the room."); 
			GUI.Button(new Rect( (Screen.width/2)-150 , (Screen.height/8)+95 , 350,20), "Take your anger out at whatever caused the incident."); 
			if (Input.GetKeyUp(KeyCode.Z)) {
				Debug.Log("Pressed Button Z");
				letty++;
				pressed = true;
				Q4 = false; 
				result = true;
			}
			else if (Input.GetKeyUp(KeyCode.X)) {
				Debug.Log("Pressed Button X");
				brian++;
				pressed = true;
				Q4 = false; 
				result = true;
			}
			else if (Input.GetKeyUp(KeyCode.C)) {
				Debug.Log("Pressed Button C");
				hobbs++;
				pressed = true;
				Q4 = false; 
				result = true;
			}
			else if (Input.GetKeyUp(KeyCode.V)) {
				Debug.Log("Pressed Button V");
				dom++;
				pressed = true;
				Q4 = false; 
				result = true;
			}
		}

		if(result) {
			int[] array = {0, dom, brian, letty, hobbs}; 
			int max = 0;
			int maxIndex = 0; 

			for(int i=0; i<array.Length; i++) { 
				if(array[i] > max) { 
					max = array[i]; 
					maxIndex = i;
				}
			}


			if(maxIndex == 1) { 
				Debug.Log ("dom"); 
				result = false;
				transform.position = new Vector3 (8, -10, 60);
			} 
			else if(maxIndex == 2) { 
				Debug.Log ("brian");
				result = false;
				transform.position = new Vector3 (41,-19, -70); 
			} 
			else if(maxIndex == 3) { 
				Debug.Log ("letty"); 
				result = false;
				transform.position = new Vector3 (8, -49, 61);
			}
			else if(maxIndex == 4) { 
				Debug.Log ("hobbs");  
				result = false;
				transform.position = new Vector3 (7, -48, -5);
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
