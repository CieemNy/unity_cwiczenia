using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie5_lab6 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Przeszkoda"))
        {
            Debug.Log("Doszlo do kolizji");
        }
    }
}
