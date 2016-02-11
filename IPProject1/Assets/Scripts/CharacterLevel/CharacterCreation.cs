using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class CharacterCreation : MonoBehaviour {

	public GameObject GameDataCharacter;
	private List<GameObject> models;
	private int selectionIndex = 0;



	// Use this for initialization
	private void Start () {
		models = new List<GameObject>();
		foreach (Transform characters in transform)
		{
			models.Add(characters.gameObject);
			characters.gameObject.SetActive(false);
		}
		models[selectionIndex].SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Select(int index)
	{
		if (index == selectionIndex)
			return;
		if (index < 0 || index >= models.Count)
			return;
		models[selectionIndex].SetActive(false);
		selectionIndex = index;
		models[selectionIndex].SetActive(true);
	}
}


// J B R d C