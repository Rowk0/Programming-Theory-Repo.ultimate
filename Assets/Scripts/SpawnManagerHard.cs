using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerHard : SpawnManager
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(DobleSpawnEnemigoTopArriba), 1, 2f);
        InvokeRepeating(("SpawnEnemigoTopArriba"), 1, 3);
        InvokeRepeating(nameof(DobleSpawnEnemigoTopAbajo), 1, 2f);
        InvokeRepeating(("SpawnEnemigoTopAbajo"), 1, 3);
        InvokeRepeating(nameof(DobleSpawnEnemigoTopDerecha), 1, 2f);
        InvokeRepeating(("SpawnEnemigoTopDerecha"), 1, 3);
        InvokeRepeating(nameof(DobleSpawnEnemigoTopIzquierda), 1, 2f);
        InvokeRepeating(("SpawnEnemigoTopIzquierda"), 1, 3);
        InvokeRepeating(("SpawnEnemigoSeguidor"), 1, 5);
        InvokeRepeating(("SpawnPowerup"), 1, 5);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DobleSpawnEnemigoTopArriba() 
    {
        if (SceneManagerMenu.isGameActive == true)
        {
            float zTopArriba = 26.1f;
            float xTopArriba = 56;
            float randomXTopArriba = Random.Range(xTopArriba, -xTopArriba);

            Vector3 spawnPos = new(randomXTopArriba, 0.6f, zTopArriba);

            Instantiate(enemies[2], spawnPos, enemies[2].transform.rotation);

            Vector3 spawnPos1 = new(randomXTopArriba, 0.6f, zTopArriba + 2);

            Instantiate(enemies[2], spawnPos1, enemies[2].transform.rotation);
        }
    }

    void DobleSpawnEnemigoTopAbajo()
    {
        if (SceneManagerMenu.isGameActive == true)
        {
            float zTopAbajo = -26.1f;
            float xTopAbajo = -56;
            float randomXTopAbajo = Random.Range(xTopAbajo, -xTopAbajo);

            Vector3 spawnPos = new Vector3(randomXTopAbajo, 0.6f, zTopAbajo);

            Instantiate(enemies[1], spawnPos, enemies[1].gameObject.transform.rotation);

            Vector3 spawnPos1 = new(randomXTopAbajo, 0.6f, zTopAbajo - 2);

            Instantiate(enemies[1], spawnPos1, enemies[1].gameObject.transform.rotation);
        }
    }
    void DobleSpawnEnemigoTopDerecha()
    {
        if (SceneManagerMenu.isGameActive == true)
        {
            float zTopDerecha = 26.1f;
            float xTopDerecha = 56;
            float randomZTopDerecha = Random.Range(zTopDerecha, -zTopDerecha);

            Vector3 spawnPos = new Vector3(xTopDerecha, 0.6f, randomZTopDerecha);

            Instantiate(enemies[3], spawnPos, enemies[3].gameObject.transform.rotation);

            Vector3 spawnPos1 = new(xTopDerecha, 0.6f, randomZTopDerecha + 2);

            Instantiate(enemies[3], spawnPos1, enemies[3].gameObject.transform.rotation);
        }
    }
    void DobleSpawnEnemigoTopIzquierda()
    {
        if (SceneManagerMenu.isGameActive == true)
        {
            float zTopIzquierda = -26.1f;
            float xTopIzquierda = -56;
            float randomZTopIzquierda = Random.Range(zTopIzquierda, -zTopIzquierda);

            Vector3 spawnPos = new Vector3(xTopIzquierda, 0.6f, randomZTopIzquierda);

            Instantiate(enemies[4], spawnPos, enemies[4].gameObject.transform.rotation);

            Vector3 spawnPos1 = new(xTopIzquierda, 0.6f, randomZTopIzquierda - 2);

            Instantiate(enemies[4], spawnPos1, enemies[4].gameObject.transform.rotation);
        }
    }
}
