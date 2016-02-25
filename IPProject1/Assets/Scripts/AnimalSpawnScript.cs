using UnityEngine;
using System.Collections;

public class AnimalSpawnScript : MonoBehaviour {
	//Spawn Time
	public float spawnTime = 3;	
	//First Spawn Time
	public float spawnDelay = 5;	
	//Array of animals
	public GameObject[] animals;	
	
	
	void Start ()
	{
		// Start calling the Spawn function repeatedly after a delay .
		InvokeRepeating("Spawn", spawnDelay, spawnTime);
		if (gameObject.name == "Winston")
		{
			spawnTime += 5;
		}

		if (gameObject.name == "Roland") 
		{
			spawnTime += 10;
		}
	}

	
	
	void Spawn ()
	{

		// Instantiate a random enemy.
		int animalIndex = Random.Range(0, animals.Length);
		Instantiate(animals[animalIndex], transform.position, transform.rotation);
	}
}
