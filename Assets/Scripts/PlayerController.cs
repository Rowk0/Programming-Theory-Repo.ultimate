using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad;
    private Rigidbody jugadorRB;
    private float zLimite = 25;
    private float xLimite = 56;

    // Start is called before the first frame update
    void Start()
    {
        jugadorRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoJugador();
        LimitesMapa();
    }

    void MovimientoJugador()
    {
        //movimiento del jugador
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        jugadorRB.AddForce(Vector3.forward * velocidad * verticalInput);
        jugadorRB.AddForce(Vector3.right * velocidad * horizontalInput);
    }

    void LimitesMapa()
    {
        //limite arriba
        if (transform.position.z > zLimite)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zLimite);
        }
        //limite abajo
        if (transform.position.z < -zLimite)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zLimite);
        }
        //limite derecha
        if (transform.position.x > xLimite)
        {
            transform.position = new Vector3(xLimite, transform.position.y, transform.position.z);
        }
        //limite izquiera
        if (transform.position.x < -xLimite)
        {
            transform.position = new Vector3(-xLimite, transform.position.y, transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo Top Derecha"))
        {
            Destroy(gameObject);
            Debug.Log("Perdiste maceta");
        }
        if (collision.gameObject.CompareTag("Enemigo Top Izquierda"))
        {
            Destroy(gameObject);
            Debug.Log("Perdiste maceta");
        }
        if (collision.gameObject.CompareTag("Enemigo Top Arriba"))
        {
            Destroy(gameObject);
            Debug.Log("Perdiste maceta");
        }
        if (collision.gameObject.CompareTag("Enemigo Top Abajo"))
        {
            Destroy(gameObject);
            Debug.Log("Perdiste maceta");
        }
        if (collision.gameObject.CompareTag("Enemigo Seguidor"))
        {
            Destroy(gameObject);
            Debug.Log("Perdiste maceta");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Powerup"))
        {
            Destroy(other.gameObject);
        }
    }
}
