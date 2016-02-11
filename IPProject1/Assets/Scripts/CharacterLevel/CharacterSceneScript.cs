using UnityEngine;
using System.Collections;

public class CharacterSceneScript : MonoBehaviour {
	string nameText = "";
	GameObject character;

	// Use this for initialization
	void Start () 
	{
		GameObject gameData = GameObject.Find("GameData");
		if (gameData == null)
		{
			gameData = new GameObject("GameData");
			gameData.AddComponent<GameDataScript>();
		}
		else
		{
			GameDataScript gameDataScript = gameData.GetComponent<GameDataScript>(); 
			nameText = gameDataScript.playerName;
			character = gameDataScript.GameDataCharacter;
		}
	}

	
	// Update is called once per frame
	void Update () 
	{
	
	}

	// Main Menu Loading -----------------------
	IEnumerator DelayLoadMainMenu() 
	{
		GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
		Application.LoadLevel("MainMenu");
	}

	public void LoadMainMenu() 
	{
		GameObject gameData = GameObject.Find("GameData");
		if (gameData != null)
		{
			GameDataScript gameDataScript = gameData.GetComponent<GameDataScript>();
			gameDataScript.playerName = nameText;
			gameDataScript.GameDataCharacter = character;
		}
		GetComponent<AudioSource>().Play(); 
		StartCoroutine(DelayLoadMainMenu());
		Application.LoadLevel("MainMenu");
		
}

	public void SetName(string name) 
	{
		nameText = name;
	}
}
