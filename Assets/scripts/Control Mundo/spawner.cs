using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] obstacles;
    public float minTime = 0.6f;  // Tiempo mínimo entre spawns
    public float maxTime = 1.8f;  // Tiempo máximo entre spawns

    void Start()
    {
        StartCoroutine(SpawnObstacle());
    }

    private IEnumerator SpawnObstacle()
    {
        while (true)
        {
            int randomIndex = UnityEngine.Random.Range(0, obstacles.Length);
            float randomTime = UnityEngine.Random.Range(minTime, maxTime);
            Instantiate(obstacles[randomIndex], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(randomTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
