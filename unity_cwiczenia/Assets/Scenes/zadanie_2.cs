using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class zadanie2 : MonoBehaviour
{

    public float speed = 2.0f;
    public Rigidbody rb;
    Vector3 start = new Vector3(0.0f, 1.0f, 0.0f);
    Vector3 stop = new Vector3(10.0f, 1.0f, 0.0f);

    void Update()
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
