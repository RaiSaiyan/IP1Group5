using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerScript : MonoBehaviour {

	public Text timerText;
	float timeLeft = 30f;
	string currentTime;

	// Use this for initialization
	void Start () {
		timerText.text = "Time left: " + currentTime;
	}
	
	// Update is called once per frame
	void Update () {
		timerText.text = "Time left: " + currentTime;
		timeLeft -= Time.deltaTime;
		currentTime = string.Format("{0:0}", timeLeft);
		score scoreScript = GetComponent<score>();
		if (scoreScript != null)
		{
			if (timeLeft <= 0 /*&& scoreScript.playerScore < 500*/) 
			{
				Application.LoadLevel ("EndScene");
			} 
			/*else
			{
				Application.LoadLevel ("Level2");
			}*/
		}
	}
}
