using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class Grav : MonoBehaviour
{
    public Rigidbody flecha;  // Asigna el objeto de la flecha desde el inspector
    public float fuerzaDisparo = 10f;

    public void DispararFlecha()
    {
        // Aplicar una fuerza hacia adelante para disparar la flecha
        flecha.AddForce(transform.forward * fuerzaDisparo, ForceMode.Impulse);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;

public class SimuladorTiroArcoFlecha : MonoBehaviour
{
    public GameObject flechaPrefab; // Objeto de la flecha
    public Transform manoIzquierda; // Posición de la mano izquierda
    public Transform manoDerecha;   // Posición de la mano derecha
    public float fuerzaLanzamiento = 10f; // Magnitud de la fuerza de lanzamiento

    private bool flechaEnVuelo = false;
    private GameObject flechaActual;

    void Update()
    {
        // Detecta cuando se dispara el arco (por ejemplo, al hacer clic en el botón izquierdo del mouse)
        if (Input.GetMouseButtonDown(0) && !flechaEnVuelo)
        {
            LanzarFlecha();
        }
    }

    void LanzarFlecha()
    {
        // Calcula la dirección y la velocidad en función de la diferencia entre las manos
        Vector3 direccionLanzamiento = (manoDerecha.position - manoIzquierda.position).normalized;
        Vector3 velocidadLanzamiento = direccionLanzamiento * fuerzaLanzamiento;

        // Crea la flecha y configura su posición y velocidad inicial
        flechaActual = Instantiate(flechaPrefab, manoIzquierda.position, Quaternion.identity);
        Rigidbody rb = flechaActual.GetComponent<Rigidbody>();
        rb.velocity = velocidadLanzamiento;
        rb.useGravity = true;

        // Establece la flecha como en vuelo
        flechaEnVuelo = true;
    }
}
*/
