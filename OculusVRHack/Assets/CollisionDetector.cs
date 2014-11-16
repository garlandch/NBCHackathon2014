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

	void OnTriggerEnter(Collider other) { 
		Debug.Log (other.transform.name);
		if(other.transform.name.Equals ("Collision5")) { 
			Debug.Log ("Collision 5 detected");
			transform.position = new Vector3 (4, -20, -5);
		} 
		if(other.transform.name.Equals ("Collision4")) { 
			Debug.Log ("Collision 4 detected");
			transform.position = new Vector3 (4, -20, -5);
		}
		if(other.transform.name.Equals ("Collision3")) { 
			Debug.Log ("Collision 3 detected");
			transform.position = new Vector3 (4, -20, -5);
		}
		if(other.transform.name.Equals ("Collision2")) { 
			Debug.Log ("Collision 2 detected");
			transform.position = new Vector3 (4, -20, -5);
		}
		if(other.transform.name.Equals ("Collision1")) { 
			Debug.Log ("Collision 1 detected");
			transform.position = new Vector3 (4, -20, -5);
		}
		if(other.transform.name.Equals ("DomCollision")) { 
			Debug.Log ("Dom detected");
			transform.position = new Vector3 (8, -10, 60);
		}
		if(other.transform.name.Equals ("HobbsCollision")) { 
			Debug.Log ("Hobbs detected");
			transform.position = new Vector3 (7, -48, -5);
		}
		if(other.transform.name.Equals ("LettyCollision")) { 
			Debug.Log ("Letty detected");
			transform.position = new Vector3 (8, -49, 61);
		}
		if(other.transform.name.Equals ("BrianCollision")) { 
			Debug.Log ("Brian detected");
			transform.position = new Vector3 (41, -19, -70);
		}
	}
}
