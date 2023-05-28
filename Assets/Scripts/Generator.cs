using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private GameObject obstacle;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1f, 0.5f);
    }

    private void SpawnObstacle()
    {
        Instantiate(obstacle, points[Random.Range(0, points.Length)].position, Quaternion.identity);
    }
}
