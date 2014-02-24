using UnityEngine;
using System.Collections;

public class OnCollider : MonoBehaviour {

	void OnCollisionEnter(Collision collision){
		Debug.Log("Collision Enter.");
	}
	void OnCollisionStay(Collision collision){
		Debug.Log("Collision Stay.");
	}
	void OnCollisionExit(Collision collision){
		Debug.Log("Collision Exit.");
	}
}
