using UnityEngine;
using System.Collections;

public class goneOnTouch : MonoBehaviour {

	bool checkThis = false;
	// Use this for initialization
	void Start () 
	{
		//checkThis = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (checkThis) 
		{
			transform.Translate(Vector3.left);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		// Checking for the appropriate tag
		if (other.gameObject.CompareTag("PickUp"))
		{
			Destroy(gameObject);
			Debug.Log("Animal and Food have been destroyed.");
		}
	}

	public void changeBool()
	{
		checkThis = true;
		//Debug.Log ("HERE");
	}
}
