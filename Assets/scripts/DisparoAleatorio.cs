using UnityEngine;

public class DisparoAleatorio : MonoBehaviour
{
    public GameObject prefabBala;
    public Transform[] puntosDisparo;
    public float intervaloDisparo = 2f; // Intervalo de tiempo entre cada disparo
    public float velocidadBala = 10f;   // Velocidad de la bala
    private float tiempoUltimoDisparo;

    private void Start()
    {
        // Asigna los puntos de disparo manualmente o busca en la jerarquía
        // Por ejemplo:
        // puntosDisparo = new Transform[3];
        // puntosDisparo[0] = transform.Find("PuntoDisparo1");
        // puntosDisparo[1] = transform.Find("PuntoDisparo2");
        // puntosDisparo[2] = transform.Find("PuntoDisparo3");

        tiempoUltimoDisparo = Time.time;
    }

    private void Update()
    {
        // Verifica si es tiempo de disparar
        if (Time.time >= tiempoUltimoDisparo + intervaloDisparo)
        {
            Disparar();
            tiempoUltimoDisparo = Time.time;
        }
    }

    private void Disparar()
    {
        if (prefabBala == null)
        {
            Debug.LogError("El prefab de la bala no está asignado en el inspector.");
            return;
        }

        if (puntosDisparo == null || puntosDisparo.Length == 0)
        {
            Debug.LogError("No se han asignado puntos de disparo.");
            return;
        }

        // Elige un punto de disparo aleatorio
        int indicePunto = Random.Range(0, puntosDisparo.Length);
        Transform puntoDisparo = puntosDisparo[indicePunto];

        // Instancia el prefab de bala en el punto de disparo seleccionado
        GameObject balaInstanciada = Instantiate(prefabBala, puntoDisparo.position, Quaternion.identity);

        // Accede al componente Rigidbody2D de la bala instanciada y aplica una velocidad
        Rigidbody2D rbBala = balaInstanciada.GetComponent<Rigidbody2D>();
        if (rbBala != null)
        {
            // Aplica una velocidad hacia la izquierda (en el eje local de la bala)
            rbBala.velocity = -balaInstanciada.transform.right * velocidadBala;
        }
        else
        {
            Debug.LogWarning("La bala instanciada no tiene un Rigidbody2D. Asegúrate de añadir uno si quieres aplicar velocidad.");
        }
    }
}
