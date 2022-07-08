using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] meteorPrefabs;
    [SerializeField] private float spawnDelay = 2.0f;
    [SerializeField] float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMeteor",spawnDelay,spawnInterval);
    }

    void SpawnMeteor() {
        float xRandom = Random.Range(-150,150);
        float zRandom = Random.Range(-50,50);
        Vector3 spawnPos = new Vector3(xRandom,0,zRandom);

        int meteorIndex = Random.Range(0,meteorPrefabs.Length);

        Instantiate(meteorPrefabs[meteorIndex],spawnPos,meteorPrefabs[meteorIndex].transform.rotation);
    }

   
}
