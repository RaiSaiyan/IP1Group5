using UnityEngine;
using System.Collections;

public class OptionsScript : MonoBehaviour {
	// Main Level Loading -----------------------------
	IEnumerator DelayLoadMainMenu() 
	{
		GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
		Application.LoadLevel("MainMenu");
	}

	public void LoadMainMenu() 
	{
		GetComponent<AudioSource>().Play(); 
		StartCoroutine(DelayLoadMainMenu());
		Application.LoadLevel("MainMenu");  
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
