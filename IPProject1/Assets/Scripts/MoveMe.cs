using UnityEngine;
using System.Collections;

public class MoveMe : MonoBehaviour
{
	Vector3 origPos, curMousePos;
	public GameObject food;
	GameObject foodClone;
	goneOnTouch test;
	Vector3 movement = new Vector3 (1, 0, 0);


	void Update()
	{
		// Checking to see if the mouse button is pressed down, if not, exits the if.
		if (!Input.GetMouseButtonDown (0)) 
			return;

		if (Input.mousePosition.y > -3) 
		{
			curMousePos = camera.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0));
		
			// Position relative to the eye-point of the camera
			curMousePos -= transform.position;
			//Sets the food visibility to active
			food.SetActive (true);
			//Stores the original position of the food.
			origPos = food.transform.position;
			//Moves the food to the mouse position
			food.transform.Translate(curMousePos);

			StartCoroutine ("DragObject");
		}

		/*if (foodClone) 
		{
			Destroy (foodClone);
		}*/
	}
	
	IEnumerator DragObject()
	{
		while (Input.GetMouseButton (0))
		{
			// Position on the camera in relation to the world
			Vector3 newMousePos = camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
			
			// Position relative to the eye-point of the camera
			newMousePos -= transform.position;
			
			food.transform.Translate(newMousePos - curMousePos);
			curMousePos = newMousePos;

			yield return 0;
		}

		foodClone = (GameObject)Instantiate(food, curMousePos, transform.rotation);
		test = foodClone.GetComponent<goneOnTouch> ();
		test.changeBool ();
		food.transform.position = origPos;
		food.SetActive (false);
	}
}
