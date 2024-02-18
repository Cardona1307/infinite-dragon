using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class scroll : MonoBehaviour
{
    private float scrollSpeed = 20f;

    void Update()
    {
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);
    }
}
