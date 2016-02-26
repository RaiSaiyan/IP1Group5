using UnityEngine;
using System.Collections;

public class GameDataScript : MonoBehaviour {
	// The volume 
	public float volume = 1.0f;
	// The score
	public int score;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
