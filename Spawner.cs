using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    public Transform borderR;
    public Transform borderL;

    public float spawnInterval;
    public float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0)
        {
            Spawn();
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(borderL.position.x, borderR.position.x);

        Vector2 newPos = transform.position;
        newPos.x = randomX;

        Instantiate(prefab, newPos, Quaternion.identity);
        spawnTimer = spawnInterval;
    }
}
