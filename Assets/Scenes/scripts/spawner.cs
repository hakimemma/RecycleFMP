using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn;

    float timeTonextSpawn;
    float timesinceLastSpawn = 0.0f;

    public float minSpawnTime = 0.5f;
    public float maxSpawnTime = 3.0f;

    void Start()
    {
        timeTonextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
    }

    void Update()
    {
        timesinceLastSpawn = timesinceLastSpawn + Time.deltaTime;

        if (timesinceLastSpawn > timeTonextSpawn)
        {
            int selection = Random.Range(0, objectsToSpawn.Length);

            Instantiate(objectsToSpawn[selection], transform.position, Quaternion.identity);

            timeTonextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
            timesinceLastSpawn = 0.0f;

        }
    }
}
