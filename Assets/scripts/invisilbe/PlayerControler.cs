using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Renderer playerRenderer; // Componente Renderer del personaje
    public bool isInvisible = false; // Estado de invisibilidad actual
    private float invisibilityTimer = 0f; // Temporizador para contar la duración de invisibilidad
    private Color originalColor; // Color original del jugador

    private void Start()
    {
        // Obtener el componente Renderer del personaje
     
        originalColor = playerRenderer.material.color; // Guardar el color original del material
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

    // Método para activar la invisibilidad con una opacidad reducida
    public void SetInvisibility(float duration, float alpha)
    {
        isInvisible = true;
        invisibilityTimer = duration;

        // Cambiar el color del material para hacerlo semi-transparente
        Color newColor = originalColor;
        newColor.a = alpha; // Establecer el nuevo valor de opacidad
        playerRenderer.material.color = newColor;
    }

    // Método para hacer visible al personaje (restaurar la opacidad original)
    private void SetVisible()
    {
        if (playerRenderer != null)
        {
            playerRenderer.material.color = originalColor; // Restaurar el color original
        }
        isInvisible = false;
    }
}

