using UnityEngine;
using System.Collections;

public class OnTrigger : MonoBehaviour {
	
	void OnTriggerEnter(Collider collider){
		Debug.Log("Collider Enter.");
	}
	void OnTriggerStay(Collider collider){
		Debug.Log("Collider Stay.");
	}
	void OnTriggerExit(Collider collider){
		Debug.Log("Collider Exit.");
	}
}
