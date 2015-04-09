using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneScript : MonoBehaviour {
	public static int life = 3;
	public static int score = 0;

	public Text scoreText;
	public Text lifeText;

	// Use this for initialization
	void Start () {
		scoreText.text =  score.ToString();
		lifeText.text = life.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text =  score.ToString();
		lifeText.text = life.ToString ();
	}
	public static void Initialize() {
		life = 3;
		score = 0;
	}
}
