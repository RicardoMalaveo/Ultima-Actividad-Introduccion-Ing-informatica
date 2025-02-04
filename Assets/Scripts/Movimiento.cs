using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad = 5f;
    public float velocidadRotacion = 100f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void FixedUpdate()
    {
        float movimiento = Input.GetAxis("Vertical") * velocidad;
        float rotacion = Input.GetAxis("Horizontal") * velocidadRotacion;
        Vector3 direccion = transform.forward * movimiento;
        rb.velocity = new Vector3(direccion.x, rb.velocity.y, direccion.z);
        Quaternion deltaRot = Quaternion.Euler(new Vector3(0, rotacion * Time.fixedDeltaTime, 0));
        rb.MoveRotation(rb.rotation * deltaRot);
    }
}
