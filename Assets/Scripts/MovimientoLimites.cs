using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class MovimientoLimites : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody enemyRB;
    private GameObject player;
    private bool isGameActiveTest;
    

    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        isGameActiveTest = SceneManagerMenu.isGameActive;
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameActiveTest == true)
        {
            Movimiento();
        }
        DestruccionDeCopias();
    }

    void Movimiento()
    {
        if (CompareTag("Enemigo Top Derecha")) 
        {
            enemyRB.AddForce(Vector3.left * speed);
        }
        if (CompareTag("Enemigo Top Izquierda"))
        {
            enemyRB.AddForce(Vector3.right * speed);
        }
        if (CompareTag("Enemigo Top Arriba"))
        {
            enemyRB.AddForce(Vector3.back * speed);
        }
        if (CompareTag("Enemigo Top Abajo"))
        {
            enemyRB.AddForce(Vector3.forward * speed);
        }
        if (CompareTag("Enemigo Seguidor") && SceneManagerMenu.isGameActive == true)
        {
            Vector3 mirarDireccion = (player.transform.position - transform.position).normalized;
            enemyRB.AddForce(mirarDireccion *  speed);
        }
        if (CompareTag("Powerup") && SceneManagerMenu.isGameActive == true)
        {
            enemyRB.AddTorque(Vector3.up);
        }
    }

    void DestruccionDeCopias() 
    {
        float zDestroy = 30;
        float xDestroy = 61;

        //limite arriba
        if (transform.position.z > zDestroy)
        {
            Destroy(gameObject);
        }
        //limite abajo
        if (transform.position.z < -zDestroy)
        {
            Destroy(gameObject);
        }
        //limite derecha
        if (transform.position.x > xDestroy)
        {
            Destroy(gameObject);
        }
        //limite izquiera
        if (transform.position.x < -xDestroy)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() && PlayerController.hasPowerup == true)
        {
            Destroy(gameObject);
        }
    }
}
