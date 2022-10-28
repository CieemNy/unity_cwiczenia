using System.Collections;
using System.Collections.Generic;
using UnityEngine;
zadanie4 : MonoBehaviour
{
    // ruch wok� osi Y b�dzie wykonywany na obiekcie gracza, wi�c
    // potrzebna nam referencja do niego (konkretnie jego komponentu Transform)
    public Transform player;
    float RotationX = 0f;
    float RotationY = 0f;
    public float sensitivity = 350f;

    void Start()
    {
        // zablokowanie kursora na �rodku ekranu, oraz ukrycie kursora
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {
        // pobieramy warto�ci dla obu osi ruchu myszy
        float mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseYMove = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // wykonujemy rotacj� wok� osi Y
        player.Rotate(Vector3.up * mouseXMove);

        RotationX += mouseXMove;
        RotationY += mouseYMove;

        RotationY = Mathf.Clamp(RotationY, -90f, 90f);
        transform.localRotation = Quaternion.Euler(-RotationY, RotationX, 0f);
    }
}
