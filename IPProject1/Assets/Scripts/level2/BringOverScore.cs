using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BringOverScore : MonoBehaviour {

	public Text scoreText; 

	// Use this for initialization
	void Start () {
		GameObject gameData = GameObject.Find("GameData");
		
		if (gameData != null)
		{
			GameDataScript gameDataScript = gameData.GetComponent<GameDataScript>();
			scoreText.text = "Score: "  + gameDataScript.score.ToString(); // Adds the players name from the options scene and the players score from the main level
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
