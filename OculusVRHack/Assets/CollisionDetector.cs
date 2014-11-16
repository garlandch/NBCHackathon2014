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
	}
}
