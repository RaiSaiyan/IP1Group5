using UnityEngine;
using System.Collections;

public class ClickNSpawn : MonoBehaviour {

	public GameObject food;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown("Fire1"))
		{
			//Instantiate (food, Transform.position, Quaternion.identity);


		}
	}

	/*public void FoodSpawn()
	{
		GetComponent (gameObject.food);
	}*/
}
