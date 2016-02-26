using UnityEngine;
using System.Collections;

public class StartSaving : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject gameData = GameObject.Find("GameData");
		if (gameData== null)
		{
			gameData = new GameObject("GameData"); // If the scirpt cannot find the GameData object then create a new one
			gameData.AddComponent<GameDataScript>();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
