using UnityEngine;
using System.Collections;

public class FoodSwitchScript : MonoBehaviour {

	public GameObject foodObject;
	public Sprite carrotImage;
	public Sprite meatImage;
	
	void Start()
	{

	}

	public void CarrotSwitch()
	{
		foodObject.GetComponent<SpriteRenderer> ().sprite = carrotImage;
	}

	public void MeatSwitch()
	{
		foodObject.GetComponent<SpriteRenderer> ().sprite = meatImage;
	}
}
