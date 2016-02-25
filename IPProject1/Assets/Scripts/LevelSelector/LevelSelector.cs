using UnityEngine;
using System.Collections;

public class LevelSelector : MonoBehaviour {
	// Level 1 Loading -----------------------------
	IEnumerator DelayLoadLevel1()
	{
		{
			GetComponent<AudioSource>().Play();
			yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
			Application.LoadLevel("Test");
		}
	}

	public void LoadMainLevel() 
	{
		GetComponent<AudioSource>().Play();
		StartCoroutine(DelayLoadLevel1());
		Application.LoadLevel("Test");
	}

	// Level 2 Loading -----------------------------
	IEnumerator DelayLoadLevel2()
	{
		{
			GetComponent<AudioSource>().Play();
			yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
			Application.LoadLevel("Level2");
		}
	}
	
	public void LoadMainLevel2() 
	{
		GetComponent<AudioSource>().Play();
		StartCoroutine(DelayLoadLevel2());
		Application.LoadLevel("Level2");
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
