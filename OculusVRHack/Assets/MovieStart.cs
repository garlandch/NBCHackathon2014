using UnityEngine;
using System.Collections;

public class MovieStart : MonoBehaviour {

	bool pressed = false;
	bool playing = false;
	// Use this for initialization
	void Start () {
		MovieTexture movie = renderer.material.mainTexture as MovieTexture; 
		audio.clip = movie.audioClip; 
		movie.loop = true;
		movie.Play ();
		audio.Play ();

		audio.volume = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (pressed) { pressed = false; return; } 
		if(Input.GetKeyDown(KeyCode.P)) {
			if(playing) { 
				audio.volume = 0; 
				playing = false; 
				return;
			}
			pressed = true; 
			playing = true;
			audio.volume = 1;
		}
	}
}
