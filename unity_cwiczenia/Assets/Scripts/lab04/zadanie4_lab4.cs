using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie4_lab4 : MonoBehaviour
{

    public Transform player;
    float RotationX = 0f;
    float RotationY = 0f;
    public float sensitivity = 200f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseYMove = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        player.Rotate(Vector3.up * mouseXMove);
        RotationX += mouseXMove;
        RotationY += mouseYMove;
        RotationY = Mathf.Clamp(RotationY, -90f, 90f);

        transform.localRotation = Quaternion.Euler(-RotationY, RotationX, 0f);

    }
}
