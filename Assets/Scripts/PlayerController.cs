using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float m_velocidad = 10;
    public float velocidad 
    {  
        get { return m_velocidad; }
        set { m_velocidad = value;}
    }
    private Rigidbody jugadorRB;
    private float zLimite = 25;
    private float xLimite = 56;
    public static bool hasPowerup = false;
    public GameObject powerupIndicator;
    

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

        powerupIndicator.transform.Rotate(Vector3.up);
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
        if(collision.gameObject.GetComponent<MovimientoLimites>() && hasPowerup == false)
        {
            Destroy(gameObject);
            Debug.Log("Perdiste maceta");
            SceneManagerMenu.GameOver();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Powerup"))
        {
            StopAllCoroutines();
            Destroy(other.gameObject);
            hasPowerup = true;
            powerupIndicator.SetActive(true);
            StartCoroutine(Powerup());
        }
    }

    IEnumerator Powerup()
    {
        yield return new WaitForSeconds(5);
        hasPowerup = false;
        powerupIndicator.SetActive(false);
    }
}
