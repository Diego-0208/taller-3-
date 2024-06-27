using UnityEngine;

public class EnemyTimeController : MonoBehaviour
{
    private float originalTimeScale = 1f; // Escala de tiempo original
    private bool isSlowed = false; // Estado de si el tiempo está ralentizado
    private float slowdownDuration = 0f; // Duración restante del efecto de ralentización

    private void Start()
    {
        originalTimeScale = Time.timeScale; // Guardar la escala de tiempo original
    }

    private void Update()
    {
        // Si el tiempo está ralentizado, contar el tiempo restante y restaurar el tiempo normal cuando termine
        if (isSlowed)
        {
            slowdownDuration -= Time.deltaTime;
            if (slowdownDuration <= 0f)
            {
                RestoreTimeScale();
            }
        }
    }

    // Método para ralentizar el tiempo
    public void SlowDownTime(float scale, float duration)
    {
        if (!isSlowed)
        {
            Time.timeScale = scale;
            isSlowed = true;
            slowdownDuration = duration;
        }
    }

    // Método para restaurar la escala de tiempo original
    private void RestoreTimeScale()
    {
        Time.timeScale = originalTimeScale;
        isSlowed = false;
    }
}
