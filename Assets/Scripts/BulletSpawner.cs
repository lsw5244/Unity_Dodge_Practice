using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject target;
    public GameObject bullet;

    public float spawnDelay = 0.0f;
    public float minSpawnDelay = 0.5f;
    public float maxSpawnDelay = 2.0f;

    private float elapsedTime = 0.0f;
    void Start()
    {
        spawnDelay = Random.Range(minSpawnDelay, maxSpawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if(elapsedTime >= spawnDelay)
        {
            elapsedTime = 0.0f;
            GameObject b = Instantiate(bullet, transform.position, transform.rotation);

            b.transform.LookAt(target.transform.position);

            spawnDelay = Random.Range(minSpawnDelay, maxSpawnDelay);
        }
    }
}
