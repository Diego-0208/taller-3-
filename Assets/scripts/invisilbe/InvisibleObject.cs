using UnityEngine;

public class InvisibleObject : MonoBehaviour
{
    public float invisibilityDuration = 5f; // Duración en segundos de la invisibilidad

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Llamar al método de invisibilidad en el controlador del personaje
            PlayerController playerController = other.GetComponent<PlayerController>();
            if (playerController != null)
            {
                playerController.SetInvisibility(invisibilityDuration);
            }

            // Opcional: Desactivar el objeto interactuable si solo debe funcionar una vez
            gameObject.SetActive(false);
        }
    }
}

