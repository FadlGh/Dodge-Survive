using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameMaster gm;
    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        StartCoroutine(timer());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gm.KillPlayer();
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
