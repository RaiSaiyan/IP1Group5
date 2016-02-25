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
		Destroy(gameObject);
	}

	public void changeBool()
	{
		checkThis = true;
		//Debug.Log ("HERE");
	}
}
