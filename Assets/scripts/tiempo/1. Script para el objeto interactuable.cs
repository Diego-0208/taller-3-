using UnityEngine;

public class TimeSlowObject : MonoBehaviour
{
    public float timeScale = 0.5f; // Escala de tiempo cuando se ralentiza
    public float duration = 5f; // Duraci�n en segundos del efecto de ralentizaci�n

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Llamar al m�todo de ralentizaci�n del tiempo en el controlador de enemigos
            EnemyTimeController[] enemies = FindObjectsOfType<EnemyTimeController>();
            foreach (EnemyTimeController enemy in enemies)
            {
                enemy.SlowDownTime(timeScale, duration);
            }

            // Opcional: Desactivar el objeto interactuable si solo debe funcionar una vez
            gameObject.SetActive(false);
        }
    }
}
