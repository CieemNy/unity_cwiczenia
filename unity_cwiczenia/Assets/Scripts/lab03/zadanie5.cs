using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie5 : MonoBehaviour
{
    public GameObject Cube;
    private int i = 0;
    void Start()
    {
        while (i < 10)
        {
            Vector3 position = new Vector3(Random.Range(-49, 49), 1, Random.Range(-49, 49));
            Collider[] collision = Physics.OverlapSphere(position, 1);
            if (collision.Length == 0)
            {
                Instantiate(Cube, position, Quaternion.identity);
                i++;
            }
        }
    }
}
