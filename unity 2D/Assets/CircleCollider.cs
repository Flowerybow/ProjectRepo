using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleCollider : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Random.Range(-200, 200), 500);
    }

    private void Upadte() {

        if (WinCondition.hasWon)
        {
            rb.velocity = Vector2.zero;
            rb.simulated = false;
            rb.isKinematic = true;
        }
    
    }
}
