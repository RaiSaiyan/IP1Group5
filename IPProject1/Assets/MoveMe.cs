using UnityEngine;
using System.Collections;

public class MoveMe : MonoBehaviour {
	public float movementSpeed = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);
	}	
}
