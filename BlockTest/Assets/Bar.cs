using UnityEngine;
using System.Collections;

public class Bar : MonoBehaviour {

	float accel = 10.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.AddForce (
			transform.right * Input.GetAxisRaw ("Horizontal") * accel, 
			ForceMode.Impulse
		);

	}
}
