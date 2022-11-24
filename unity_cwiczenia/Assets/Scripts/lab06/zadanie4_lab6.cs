using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie4_lab6 : MonoBehaviour
{
    private float jumpForce = 5f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * (jumpForce * 3), ForceMode.Impulse);
        }
    }
}
