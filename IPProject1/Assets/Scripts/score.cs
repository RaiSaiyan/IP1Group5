using UnityEngine;
using System.Collections;

/*This class manages the persistant data while the game is being played.
 * The methods are called by other classes to modify the score and lives
 * depending on the situation*/
public class score : MonoBehaviour {
	// These variables will store the players score and lives
	int playerScore = 0;
	int lives = 3;
	
	// This method is called by other classes. An integer is passed in which changes the score
	public void ModifyScore(int value)
	{
		// The int value is added to playerScore. If it is negative it lowers the score
		playerScore += value;
	}
	
	/*This method is called by other classes to modify the lives. An integer is passed in to
	 * increase or decrease the lives*/
	public void ModifyLives(int value)
	{
		/*The int value is used to increase or decrease the lives depending on whether it is
		 * positive or nagative*/
		lives += value;
	}
}

