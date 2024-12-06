using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBehavior : MonoBehaviour
{
    public GameObject Bricks1;
    public float distance = 60f;
    public Vector3 direction = Vector3.right;

    private WinCondition winCondition;

    void Start()
    {
        winCondition = FindObjectOfType<WinCondition>();
        SpawnObjects();
    }

    void SpawnObjects()
    {
       if (transform.position.x < 450)
        {
            Vector3 spawnPosition = transform.position + direction.normalized * distance;

            Instantiate(Bricks1, spawnPosition, Quaternion.identity);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    void OnDestroy()
    {
        if (winCondition != null)
        {
            winCondition.TargetDestroyed();
        }
    }

}

