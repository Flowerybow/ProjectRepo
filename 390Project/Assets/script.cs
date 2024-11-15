using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class script : MonoBehaviour
{

    [SerializeField]
    private float health = 100;
    private float initialHealth;
    private MeshRenderer meshRenderer;

    const float moveSpeed = 10.0f;
    private float moveDistance = 0.5f;
    private float moveDuration = 0.5f;

    private Vector3 startPosition;
    private bool isMoving = false;
    
    
    // Start is called before the first frame update
    private void Start()
    {
        initialHealth = 100;
        meshRenderer = GetComponent<MeshRenderer>();
        startPosition = transform.position;

    }

    // Update is called once per frame
    private void Update()
    {
        ColorChanger();

        if (Input.GetKeyDown(KeyCode.F) && !isMoving)
        {
            health -= 10f;
            ColorChanger();
            StartCoroutine(MoveForDuration());
            
        }

        if (isMoving) {
            float newX = startPosition.x + Mathf.PingPong(Time.time * moveSpeed, moveDistance) - (moveDistance / 2);
            transform.position = new Vector3(newX, startPosition.y, startPosition.z);
        }

        if (health < 0) {
            Destroy(gameObject);
        }
    }

    private void ColorChanger() {
        var percentRemaining = health / initialHealth;
        meshRenderer.material.color = Color.Lerp(Color.red, Color.green, percentRemaining);
    }

    private IEnumerator MoveForDuration() {
        isMoving = true;

        yield return new WaitForSeconds(moveDuration);

        isMoving = false;

        transform.position = startPosition;
    }
}
