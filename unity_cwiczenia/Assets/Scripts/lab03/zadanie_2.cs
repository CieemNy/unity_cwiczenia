using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class zadanie_2 : MonoBehaviour
{

    public float speed = 2.0f;
    public Rigidbody rb;
    Vector3 start = new Vector3(0f, 1f, 0f);
    Vector3 stop = new Vector3(10f, 1f, 0f);



    void Update()
    {

    }

    void FixedUpdate()
    {
        if (rb.transform.position == start)
        {
            rb.AddForce(Vector3.right * speed, ForceMode.Impulse);

        }
        if (rb.transform.position == stop)
        {
            rb.AddForce(Vector3.left * speed, ForceMode.Impulse);
        }

    }
}
