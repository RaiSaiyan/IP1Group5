using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {
	// Main Level Loading -----------------------------
	IEnumerator DelayLoadMainLevel()
	{
		{
			GetComponent<AudioSource>().Play();
			yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
			Application.LoadLevel("MainLevel");
		}
	}

	public void LoadMainLevel() 
	{
		GetComponent<AudioSource>().Play();
		StartCoroutine(DelayLoadMainLevel());
		Application.LoadLevel("MainLevel");
	}

	// Options Level Loading -----------------------------
	IEnumerator DelayLoadOptionsLevel() 
	{
		GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
		Application.LoadLevel("OptionsLevel");
	}

	public void LoadOptionsLevel() 
	{
		GetComponent<AudioSource>().Play();
		StartCoroutine(DelayLoadOptionsLevel());
		Application.LoadLevel("OptionsLevel");
	}

	// Character Level Loading -----------------------------
	IEnumerator DelayLoadCharacterLevel()
	{
		GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
		Application.LoadLevel("Character");
	}

	public void LoadCharacterLevel()
	{
		GetComponent<AudioSource>().Play();
		StartCoroutine (DelayLoadOptionsLevel());
		Application.LoadLevel("Character");
	}

	// Quit Game -----------------------------
	IEnumerator DelayExitApplication() 
	{
		GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
		Application.Quit();
	}

	public void QuitGame() 
	{
		GetComponent<AudioSource>().Play();
		StartCoroutine(DelayExitApplication());
		Application.Quit();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
