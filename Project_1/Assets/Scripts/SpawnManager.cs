using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] meteorPrefabs; // array of meteor prefabs
    [SerializeField] private float spawnDelay = 2.0f; // spawn delay
    [SerializeField] float spawnInterval = 1.5f; // spawn interval
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMeteor",spawnDelay,spawnInterval); // invoke repeating function to spawn meteor.
    }

    void SpawnMeteor() {
        float xRandom = Random.Range(-150,150); // random x position
        float zRandom = Random.Range(-50,50); // random z position
        Vector3 spawnPos = new Vector3(xRandom,0,zRandom); // set spawn position

        int meteorIndex = Random.Range(0,meteorPrefabs.Length); // get random meteor index 

        Instantiate(meteorPrefabs[meteorIndex],spawnPos,meteorPrefabs[meteorIndex].transform.rotation); // spawn meteor
    }

   
}
