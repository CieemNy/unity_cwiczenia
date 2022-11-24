using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie1_lab6 : MonoBehaviour
{
    public float Speed = 2f;
    private bool isMoving = false;
    public float distance = 10f;
    private float pointA;
    private float pointB;

    void Start()
    {
        pointB = transform.position.x + distance;
        pointA = transform.position.x;
    }

    void FixedUpdate()
    {

        if (transform.position.x < pointA && Speed < 0)
        {
            Speed = 3f;
        }
        else if (transform.position.x >= pointB)
        {
            Speed = -Speed;
        }
        if (isMoving)
        {
            Vector3 move = transform.right * Speed * Time.deltaTime;
            transform.Translate(move);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(transform);
            isMoving = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(null);
            isMoving = false;
        }
    }
}