using UnityEngine;
using System.Collections;
using System.Collections.Generic;


   

public class PlayerController : MonoBehaviour
{
    public float lateralSpeed = 5f; // Velocidad de movimiento lateral
    public float jumpForce = 5f;   // Fuerza del salto
    public LayerMask Piso;  // Capa del suelo para detecci�n de colisiones
    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movimiento lateral
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 lateralMovement = new Vector3(horizontalInput * lateralSpeed, rb.linearVelocity.y, 0);
        rb.linearVelocity = lateralMovement;

        // Salto
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f, Piso);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}

