using UnityEngine;
using System.Collections;

public class AnimalSpawnScript : MonoBehaviour {
	//Spawn Time
	float spawnTime = 5;	
	//First Spawn Time
	float spawnDelay = 5;	
	//Array of animals
	public GameObject[] animals;
	//Array of spawns
	//public Transform[] spawns;
	//Max number of animals
	public int maxAnimals = 4;
	public int currentAnimals;

	void Start ()
	{
		// Start calling the Spawn function repeatedly after a delay .
		InvokeRepeating("Spawn", Random.Range(1,10), Random.Range(1,10));
		if (gameObject.name == "Winston")
		{
			spawnTime += 5;
		}

		if (gameObject.name == "Roland") 
		{
			spawnTime += 10;
		}
	}

	void update()
	{
		if (currentAnimals == maxAnimals)
			return;
		else 
		{
			Spawn();
		}
	}
	
	void Spawn ()
	{
		// Instantiate a random enemy.
		/*int spwanPointIndex = Random.Range(0, spawns.Length);
		Instantiate(animals[animalIndex], spawns[spwanPointIndex].position, spawns[spwanPointIndex].rotation);*/
		int animalIndex = Random.Range(0, animals.Length);
		Instantiate(animals[animalIndex], transform.position, transform.rotation);
		currentAnimals++;
	}



	/*IEnumerator startSpawn()
	{
		yield return StartCoroutine (spawnAnimal ());
	}
	IEnumerator spawnAnimal()
	{
		yield return new WaitForSeconds (Random.Range (1, 5));
		int animalIndex = Random.Range(0, animals.Length);
		Instantiate(animals[animalIndex], transform.position, transform.rotation);
		currentAnimals++;
	}*/
}
