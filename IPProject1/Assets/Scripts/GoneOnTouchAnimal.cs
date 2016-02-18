using UnityEngine;
using System.Collections;

public class GoneOnTouchAnimal : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		// Checking for the appropriate tag
		if (other.gameObject.CompareTag("PickUp"))
		{
			Destroy(gameObject);
			Destroy(other.gameObject);
			Debug.Log("Animal and Food have been destroyed.");
		}
	}
}
