using System.Collections;
using UnityEngine;

public class scroll : MonoBehaviour
{
    public float speed = 20f;
    public float aumento = 10f;
    private float timer = 0f; // Añade un temporizador

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        timer += Time.deltaTime; // Actualiza el temporizador

        if (timer >= 10)
        {
            speed += aumento; // Aumenta la velocidad
            timer = 0; // Reinicia el temporizador
        }
    }
}
