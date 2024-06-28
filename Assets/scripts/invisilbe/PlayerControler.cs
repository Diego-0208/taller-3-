using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Renderer playerRenderer; // Componente Renderer del personaje
    private bool isInvisible = false; // Estado de invisibilidad actual
    private float invisibilityTimer = 0f; // Temporizador para contar la duración de invisibilidad

    private void Start()
    {
        // Obtener el componente Renderer del personaje
        playerRenderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        // Si está invisible, contar el tiempo y revertir la visibilidad cuando termine el tiempo
        if (isInvisible)
        {
            invisibilityTimer -= Time.deltaTime;
            if (invisibilityTimer <= 0f)
            {
                SetVisible();
            }
        }
    }

    // Método para activar la invisibilidad
    public void SetInvisibility(float duration)
    {
        isInvisible = true;
        invisibilityTimer = duration;

        // Ocultar al personaje (desactivar el renderer)
        SetInvisible();
    }

    // Método para hacer invisible al personaje
    private void SetInvisible()
    {
        if (playerRenderer != null)
        {
            playerRenderer.enabled = false;
        }
    }

    // Método para hacer visible al personaje
    private void SetVisible()
    {
        if (playerRenderer != null)
        {
            playerRenderer.enabled = true;
        }
        isInvisible = false;
    }
}
