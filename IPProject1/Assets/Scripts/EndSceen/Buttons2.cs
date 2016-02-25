using UnityEngine;
using System.Collections;

public class Buttons2 : MonoBehaviour {
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

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
