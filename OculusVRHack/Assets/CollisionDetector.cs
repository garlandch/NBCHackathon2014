using UnityEngine;
using System.Collections;

public class CollisionDetector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Yo");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator OnTriggerEnter(Collider other) { 
		Debug.Log (other.transform.name);
		if(other.transform.name.Equals ("Collision5")) { 
			Debug.Log ("Collision 5 detected");
		} 
		if(other.transform.name.Equals ("Collision4")) { 
			Debug.Log ("Collision 4 detected");
		}
		if(other.transform.name.Equals ("Collision3")) { 
			Debug.Log ("Collision 3 detected");
		}
		if(other.transform.name.Equals ("Collision2")) { 
			Debug.Log ("Collision 2 detected");
		}
		if(other.transform.name.Equals ("Collision1")) { 
			Debug.Log ("Collision 1 detected");
		}

		float fadeTime = GameObject.Find ("Ceiling").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds (fadeTime);
		transform.position = new Vector3 (8, -20, -5);
	}
}
