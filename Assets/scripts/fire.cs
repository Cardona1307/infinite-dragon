using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    [SerializeField] private float velocidad;
    public float tiempoDeVida;  // Tiempo de vida del objeto

    private void Start()
    {
        Destroy(gameObject, tiempoDeVida);  
    }

    private void Update()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("enemigo"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
