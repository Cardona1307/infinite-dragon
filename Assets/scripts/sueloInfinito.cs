using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sueloInfinito : MonoBehaviour
{
    public GameObject suelo1;
    public GameObject suelo2;
    public float velocidad = 1.0f;

    private float anchoSuelo;

    void Start()
    {
        BoxCollider2D colliderSuelo = suelo1.GetComponent<BoxCollider2D>();
        anchoSuelo = colliderSuelo.size.x;
    }

    void Update()
    {
        // Mover los suelos a la izquierda
        suelo1.transform.Translate(Vector2.left * velocidad * Time.deltaTime);
        suelo2.transform.Translate(Vector2.left * velocidad * Time.deltaTime);

        // Si el suelo1 ha salido completamente de la vista, moverlo a la derecha
        if (suelo1.transform.position.x < -anchoSuelo)
        {
            suelo1.transform.position = new Vector2(suelo2.transform.position.x + anchoSuelo, suelo1.transform.position.y);
        }

        // Si el suelo2 ha salido completamente de la vista, moverlo a la derecha
        if (suelo2.transform.position.x < -anchoSuelo)
        {
            suelo2.transform.position = new Vector2(suelo1.transform.position.x + anchoSuelo, suelo2.transform.position.y);
        }
    }
}
