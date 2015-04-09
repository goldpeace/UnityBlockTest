using UnityEngine;
using System.Collections;

public class Bottom : MonoBehaviour {
	public Ball ballObject;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision collision) {
		//Destroy(collision.gameObject);

		SceneScript.life--;

		if (SceneScript.life > 0) {
			ballObject.SendMessage ("Initialize");
		} else {
			Destroy(collision.gameObject);
		}

	}
}
