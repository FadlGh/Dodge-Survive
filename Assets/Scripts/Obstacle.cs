using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(timer());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        die();
    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(2f);
        die();
    }

    void die()
    {
        Destroy(gameObject);
    }
}
