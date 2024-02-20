using System.Collections;
using UnityEngine;

public class scroll : MonoBehaviour
{
    public float speed = 20f; 
    public float aumento = 10f; 
    private float timer = 0; 

    void Update()
    {
        
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        timer += Time.deltaTime;
        if (timer >= 10)
        {
            speed += speed + aumento;
            timer = 0;
        }
    }
}
