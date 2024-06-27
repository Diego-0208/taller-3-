using UnityEngine;

public class TimeSlowObject : MonoBehaviour
{
    public float timeScale = 0.5f; // Escala de tiempo cuando se ralentiza
    public float duration = 5f; // Duración en segundos del efecto de ralentización

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Llamar al método de ralentización del tiempo en el controlador de enemigos
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
