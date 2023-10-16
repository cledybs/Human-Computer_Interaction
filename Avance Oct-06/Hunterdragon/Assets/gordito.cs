using UnityEngine;

public class gordito : MonoBehaviour
{
    public float radioX = 1000f;       // Radio en el eje X
    public float radioY = 1000f;       // Radio en el eje Y
    public float radioZ = 1000f;       // Radio en el eje Z
    public float velocidad = 20f;    // Velocidad de movimiento
    private float angulo = 0f;      // Ángulo actual
    private Vector3 posicionInicial; // Posición inicial del dragón

    private void Start()
    {
        // Al inicio, guarda la posición inicial del dragón
        posicionInicial = transform.position;
    }

    private void Update()
    {
        // Calcular las posiciones en los tres ejes
        float x = Mathf.Cos(angulo) * radioX;
        float y = Mathf.Sin(angulo) * radioY;
        float z = Mathf.Sin(angulo) * radioZ;

        // Actualizar la posición del objeto sumando la posición inicial
        transform.position = posicionInicial + new Vector3(x, y, z);

        // Incrementar el ángulo para avanzar en el círculo
        angulo += velocidad * Time.deltaTime;

        // Asegurarse de que el ángulo permanezca en el rango [0, 2π]
        if (angulo >= Mathf.PI * 2f)
        {
            angulo = 0f;
        }
    }
}

