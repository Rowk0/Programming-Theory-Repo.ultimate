using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerup;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(("SpawnEnemigoTopArriba"), 1, 1);
        InvokeRepeating(("SpawnEnemigoTopAbajo"), 1, 1);
        InvokeRepeating(("SpawnEnemigoTopDerecha"), 1, 1);
        InvokeRepeating(("SpawnEnemigoTopIzquierda"), 1, 1);
        InvokeRepeating(("SpawnEnemigoSeguidor"), 1, 10);
        InvokeRepeating(("SpawnPowerup"), 1, 7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemigoTopArriba()
    {
        float zTopArriba = 26.1f;
        float xTopArriba = 56;
        float randomXTopArriba = Random.Range(xTopArriba, -xTopArriba);

        Vector3 spawnPos = new Vector3(randomXTopArriba, 0.6f, zTopArriba);

        Instantiate(enemies[2], spawnPos, enemies[2].gameObject.transform.rotation);
    }

    void SpawnEnemigoTopAbajo()
    {
        float zTopAbajo = -26.1f;
        float xTopAbajo = -56;
        float randomXTopAbajo = Random.Range(xTopAbajo, -xTopAbajo);

        Vector3 spawnPos = new Vector3(randomXTopAbajo, 0.6f, zTopAbajo);

        Instantiate(enemies[1], spawnPos, enemies[1].gameObject.transform.rotation);
    }


    void SpawnEnemigoTopDerecha()
    {
        float zTopDerecha = 26.1f;
        float xTopDerecha = 56;
        float randomZTopDerecha = Random.Range(zTopDerecha, -zTopDerecha);

        Vector3 spawnPos = new Vector3(xTopDerecha, 0.6f, randomZTopDerecha);

        Instantiate(enemies[3], spawnPos, enemies[3].gameObject.transform.rotation);
    }

    void SpawnEnemigoTopIzquierda()
    {
        float zTopIzquierda = -26.1f;
        float xTopIzquierda = -56;
        float randomZTopIzquierda = Random.Range(zTopIzquierda, -zTopIzquierda);

        Vector3 spawnPos = new Vector3(xTopIzquierda, 0.6f, randomZTopIzquierda);

        Instantiate(enemies[4], spawnPos, enemies[4].gameObject.transform.rotation);
    }

    void SpawnEnemigoSeguidor()
    {
        float zSpawn = 26.1f;
        float xSpawn = 56;
        float randomZSpawn = Random.Range(zSpawn, -zSpawn);
        float randomXSpawn = Random.Range(xSpawn, -xSpawn);

        Vector3 spawnPos = new Vector3(randomXSpawn, 0.6f, randomZSpawn);

        Instantiate(enemies[0], spawnPos, enemies[0].gameObject.transform.rotation);
    }

    void SpawnPowerup()
    {
        float zSpawn = 26.1f;
        float xSpawn = 56;
        float randomZSpawn = Random.Range(zSpawn, -zSpawn);
        float randomXSpawn = Random.Range(xSpawn, -xSpawn);

        Vector3 spawnPos = new Vector3(randomXSpawn, 0.6f, randomZSpawn);

        Instantiate(powerup, spawnPos, powerup.gameObject.transform.rotation);
    }
}
