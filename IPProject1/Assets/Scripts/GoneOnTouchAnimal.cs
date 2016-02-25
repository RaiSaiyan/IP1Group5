using UnityEngine;
using System.Collections;

/*This class is attached to the animal objects. It checks to see if the correct
 * food object has collided with the correct animal. Depending on what the collision
 * is, it will call methods to increase or decrease points and in the case
 * of a wrong collision, it will decrease lives.*/
public class GoneOnTouchAnimal : MonoBehaviour {
	//Variables to store the scoreScript and the scoreObject it is attached to
	score scoreScript;
	GameObject scoreObject;
	
	// Use this for initialization
	void Start () 
	{
		//Upon startup of this script it will obtain and store the scoreObject and scoreScript
		scoreObject = GameObject.Find("ScoreDataObject");
		scoreScript = scoreObject.GetComponent<score>();
	}
	
	/*This method checks for which food is making contact with which animal.
	 * The method checks the objects tag and checks to see if the correct animal was hit.
	 * It deducts points and a life if the wrong animal was hit, and adds points if the
	 * correct animal was hit*/
	void OnTriggerEnter2D(Collider2D other)
	{
		// Checking to see if the objects tag is Carrot
		if (other.tag == "Carrot") {
			// Checks if this objects name is Winston
			if (gameObject.tag == "Winston") 
			{
				// Accesses the method modifyScore in the scoreScript and adds 100 to the score
				scoreScript.ModifyScore(100);
				Destroy(gameObject);
			} 
			// Else the wrong animal was hit therefore it deducts points and a life
			else 
			{
				Debug.Log ("score- also lose life");
				scoreScript.ModifyScore(-50);
				scoreScript.ModifyLives(-1);
				Destroy(gameObject);
			}
		} 
		// Checking to see if the objects tag is Meat
		else if (other.tag == "Meat") 
		{
			// Checks to see if this objects name is Roland
			if (gameObject.tag == "Roland")
			{
				// Adds score
				scoreScript.ModifyScore(100);
				Destroy(gameObject);
			}
			// Wrong animal was hit. Deducts points and a life
			else
			{
				Debug.Log ("score- also lose life");
				scoreScript.ModifyScore(-50);
				scoreScript.ModifyLives(-1);
				Destroy(gameObject);
			}
		}
	}
}


