using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartButton : MonoBehaviour {
	public Button startButton;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartButtonClick () {
		SceneScript.Initialize();
		Application.LoadLevel ("Block");
	}
}
